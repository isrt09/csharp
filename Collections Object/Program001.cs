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
}