namespace PatternMatching
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerContact { get; set; }
    }

    public class Product : Customer
    {
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public int ProductOrderNo { get; set; }
    }

    public class Program
    {
         // Main Method
         static void Main(string[] args)
        {
            Customer customer;
            customer = new Product()
            {
                CustomerName = "James Smith",
                CustomerID = 1001,
                CustomerContact = "01916178600",
                ProductID = 10012,
                ProductPrice = 120.45,
                ProductOrderNo = 5
            };
            // Traditional way typecast e.g. Downcasting or Upcasting
            Product product = (Product) customer; 
            Console.WriteLine(product.CustomerName);
        }
    }
}