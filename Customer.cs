namespace SolarPowerEngineering
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double Order { get; set; } 

        public Customer(string firstName, string lastName, string address, double order)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Order = order;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Address: {Address}, Order: {Order} UAH";
        }
    }
}
