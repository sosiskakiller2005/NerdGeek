//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NerdGeek.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public int StatusId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual Status Status { get; set; }
    }
}
