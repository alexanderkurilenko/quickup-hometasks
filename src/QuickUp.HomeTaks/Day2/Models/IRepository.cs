using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq.Expressions;

namespace QuickUp.HomeTaks.Day2.Models
{
    public abstract class IRepository<T>
        where T:class
    {
       public abstract IEnumerable<T> GetList();
       public abstract T GetById (int id);
       public abstract void Create(T item);
       public abstract void Update(T item);
       public abstract void Delete(int id);
       public abstract void Save();

        public static TEntity Find<TEntity>(DbSet<TEntity> set, params object[] keyValues) where TEntity : class
        {
            var context = set.GetInfrastructure<IServiceProvider>().GetService<IDbContextServices>().CurrentContext.Context;
            var entityType = context.Model.FindEntityType(typeof(TEntity));
            var keys = entityType.GetKeys();
            var entries = context.ChangeTracker.Entries<TEntity>();
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            IQueryable<TEntity> query = context.Set<TEntity>();

            //first, check if the entity exists in the cache
            var i = 0;

            //iterate through the key properties
            foreach (var property in keys.SelectMany(x => x.Properties))
            {
                var keyValue = keyValues[i];

                //try to get the entity from the local cache
                entries = entries.Where(e => keyValue.Equals(e.Property(property.Name).CurrentValue));

                //build a LINQ expression for loading the entity from the store
                var expression = Expression.Lambda(
                        Expression.Equal(
                            Expression.Property(parameter, property.Name),
                            Expression.Constant(keyValue)),
                        parameter) as Expression<Func<TEntity, bool>>;

                query = query.Where(expression);

                i++;
            }

            var entity = entries.Select(x => x.Entity).FirstOrDefault();

            if (entity != null)
            {
                return entity;
            }

            //second, try to load the entity from the data store
            entity = query.FirstOrDefault();

            return entity;
        }
    }
}
