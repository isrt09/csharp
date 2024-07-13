namespace ObjectCollections
{
    // Define Product Class
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Product(int productId, string productName, double productPrice, DateTime orderDate)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.OrderDate = orderDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some products objects
            Product product1 = new Product(101,"Dell Laptop", 125.25, DateTime.Now);
            Product product2 = new Product(102,"Sumsung Laptop", 175.45, DateTime.Now);
            Product product3 = new Product(103,"Ausus Laptop", 325.26, DateTime.Now);            
        }
    }    
}