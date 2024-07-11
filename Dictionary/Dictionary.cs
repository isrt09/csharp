using System.Collections; 

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare dictionary
            Dictionary<int,string> products = new Dictionary<int,string>()
            {
                {101,"Computer Accessories"},
                {102,"Islamic Books"},
                {103, "iPhone S6"}
            };

            // Add or Insert more key, values
            products.Add(104,"Laptop Dell Inspiron N1344");

            // Update key, values
            products[104] = "Walton 27 Inch FHD Monitor";
            
            // print dictonary values
            foreach (KeyValuePair<int,string> product in products)            
            {
                Console.WriteLine($"Product Code : {product.Key}, Product Name : {product.Value}");
            }
        }
    }
}