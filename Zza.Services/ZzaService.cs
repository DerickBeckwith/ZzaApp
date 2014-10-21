namespace Zza.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Zza.Data;
    using Zza.Entities;

    public class ZzaService : IZzaService
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

        public void SubmitOrder(Order order)
        {
            this.Db.Orders.Add(order);
            order.OrderItems.ForEach(item => this.Db.OrderItems.Add(item));
            this.Db.SaveChanges();
        }
    }
}
