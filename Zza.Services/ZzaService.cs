namespace Zza.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;

    using Zza.Data;
    using Zza.Entities;

    /// <summary>
    /// Implements the Pizza Ordering Service.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ZzaService : IZzaService, IDisposable
    {
        protected readonly ZzaDbContext Db = new ZzaDbContext();

        public List<Product> GetProducts()
        {
            return this.Db.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return this.Db.Customers.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            this.Db.Orders.Add(order);
            order.OrderItems.ForEach(item => this.Db.OrderItems.Add(item));
            this.Db.SaveChanges();
        }

        public void Dispose()
        {
            this.Db.Dispose();
        }
    }
}
