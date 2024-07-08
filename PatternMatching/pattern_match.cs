namespace PatternMatching
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerContact { get; set; }
    }

    class Product : Customer
    {
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public int ProductOrderNo { get; set; }
    }
}