//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoExam.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requests()
        {
            this.Comments = new HashSet<Comments>();
        }
    
        public int RequestID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> TechTypeID { get; set; }
        public string TechModel { get; set; }
        public string Description { get; set; }
        public Nullable<int> RequestStatusID { get; set; }
        public Nullable<System.DateTime> ComplitionDate { get; set; }
        public Nullable<int> MasterID { get; set; }
        public Nullable<int> ClientID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual RequestStatuses RequestStatuses { get; set; }
        public virtual TechTypes TechTypes { get; set; }
    }
}
