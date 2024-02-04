using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer("Sam", "Ivanov", "40 Auerbacher Strasse", 1500.00),
                new Customer("Vasya", "Pupkin", "123 Zwickauer Str", 950.00),
                new Customer("Anastasia", "Dobrovolska", "17 Obere Eichstadtstrassse", 1200.00)
            };

            var highValueCustomers = CustomerCollection.FindHighValueCustomers(customers);

            Console.WriteLine("Customers with orders over 1000 UAH:");
            foreach (var customer in highValueCustomers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
