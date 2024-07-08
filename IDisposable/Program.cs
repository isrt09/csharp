
using WaltonGroupLLC;

class Program
{
    static void ProductDetails()
    {
         // Using declaration (C# 8.0) for dispose method invoke       
         using Product _product = new Product(1001,201,"Dell Inspiron N1334");
        _product.GetAllProducts();
        _product.GetProductById(5001);
        _product.UpdateProduct(301);
        _product.DeleteProduct(205);
        
    }
    static void Main(string[] args)
    {
        // calling method        
        ProductDetails();
    }
}