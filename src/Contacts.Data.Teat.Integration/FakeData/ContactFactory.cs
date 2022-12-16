using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Data.DTOs;

namespace Contacts.Data.Test.Integration.FakeData
{
    internal static class ContactFactory
    {
        static ContactFactory() { }

        public static ContactDto Create()
        {
            return new ContactDto(Guid.NewGuid(), "David Starr")
            {
                Email = "david@elegantcode.com",
                Phone = "208-577-7000",
                PartitionKey = "/partitionKey",
                Address = new AddressDto()
                {
                    Address1 = "23112 10th Ave. S.",
                    City = "Seattle",
                    PostalCode = "98198",
                    Country = "USA",
                    Region = "WA"
                }
            };
        }
    }
}
