using StructureProgram; 

// Main Method
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(2001, "iPhone 7S");  // This is structure instance; not object.
            
            Console.WriteLine("Product ID :"+ product.ProductID);
            Console.WriteLine("Product Name :"+ product.ProductName);
        }
    }