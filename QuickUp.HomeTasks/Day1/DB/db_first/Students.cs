//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickUp.HomeTasks.Day1.DB.db_first
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Nullable<int> GroupId { get; set; }
    
        public virtual Groups Groups { get; set; }
    }
}
