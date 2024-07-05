using StructureProgram; 

// Main Method
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(); // This is structure instance; not object.
            product.ProductID = 1001;
            product.ProductName = "Laptop";

            Console.WriteLine("Product ID :"+ product.ProductID);
            Console.WriteLine("Product Name :"+ product.ProductName);
        }
    }