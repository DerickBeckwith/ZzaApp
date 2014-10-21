namespace Zza.Entities
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Customer
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}
