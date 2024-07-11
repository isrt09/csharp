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

            // print dictonary values
            foreach (KeyValuePair<int,string> product in products)            
            {
                Console.WriteLine($"Product Code : {product.Key}, Product Name : {product.Value}");
            }
        }
    }
}