namespace IEnumerable
{
    // create customer
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }        
    }

    // create product 
    class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Customer customer = new Customer();                        
            Product product = new Product();                        
        }
    }
}