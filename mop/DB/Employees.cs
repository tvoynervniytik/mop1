//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Brigades = new HashSet<Brigades>();
            this.Requests = new HashSet<Requests>();
        }
    
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Passport { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> PostID { get; set; }
        public Nullable<int> EducationID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> BrigadeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Brigades> Brigades { get; set; }
        public virtual Brigades Brigades1 { get; set; }
        public virtual Education Education { get; set; }
        public virtual Posts Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
