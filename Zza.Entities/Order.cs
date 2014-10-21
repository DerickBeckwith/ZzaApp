namespace Zza.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public long Id { get; set; }

        public Guid CustomerId { get; set; }

        public int OrderStatusId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal ItemsTotal { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
