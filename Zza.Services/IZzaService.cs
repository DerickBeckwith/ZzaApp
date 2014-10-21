namespace Zza.Services
{
    using System.Collections.Generic;
    using System.ServiceModel;

    /// <summary>
    /// Definition of the Pizza Delivery Service.
    /// </summary>
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
