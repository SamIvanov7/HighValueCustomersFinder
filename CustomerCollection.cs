using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class CustomerCollection
    {
        public static IEnumerable<Customer> FindHighValueCustomers(IEnumerable<Customer> customers)
        {
            return customers.Where(customer => customer.Order > 1000);
        }
    }
}
