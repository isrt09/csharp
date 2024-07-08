namespace WaltonGroupLLC
{
    public class Product : IDisposable
    {
        public int _productId;
        public int _productCode;
        public string? _productName;        

        public Product(int productId, int productCode, string productName)
        {                        
            _productId = productId;
            _productCode = productCode;
            _productName = productName;
            Console.WriteLine("Database is connected successfully ...");
        }

        public void GetAllProducts()
        {
            Console.WriteLine("View All Products from Walton Group Ltd");
        }

        public void GetProductById(int productId)
        {
            Console.WriteLine("Walton Product : " + productId);
        }

        public void UpdateProduct(int productId)
        {
            Console.WriteLine("Walton Product Updated : " + productId);
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine("Walton Product Deleted: " + productId);
        }

        public void Dispose()
        {
            Console.WriteLine("Database Connection is closed....");
        }
    }
}