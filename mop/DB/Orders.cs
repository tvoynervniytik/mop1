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
    
    public partial class Orders
    {
        public int ID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> BrigadeID { get; set; }
        public Nullable<int> ServicesID { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Square { get; set; }
    
        public virtual Brigades Brigades { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Services Services { get; set; }
    }
}
