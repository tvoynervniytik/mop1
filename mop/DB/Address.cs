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
    
    public partial class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string RoomNumber { get; set; }
        public Nullable<int> ClientID { get; set; }
    
        public virtual Clients Clients { get; set; }
    }
}
