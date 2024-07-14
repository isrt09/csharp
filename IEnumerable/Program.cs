using System.Collections;

namespace IEnumerable
{
    // create customer
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }        
    }

    //custom collection class
    public class CustomerLists : IEnumerable
    {
        private List<Customer> customers = new List<Customer>();
        public IEnumerator GetEnumerator()
        {
            for(int i=0; i< customers.Count; i++)
            {
                yield return customers[i];
            }
        }
        public void Add(Customer customer)        
        {            
            customers.Add(customer);
        }
    }

    //custom product collection class
    class ProductList : IEnumerable
    {
        private List<Product> products;
        public IEnumerator GetEnumerator()
        {
            yield return products[0];
            yield return products[1];
            yield return products[2];
        }

        public void Add(Product _product)
        {
            products = new List<Product>()
            { 
                new Product(){ProductID = 101, ProductName = "Dell"},
                new Product(){ProductID = 201, ProductName = "Asus"},
                new Product(){ProductID = 301, ProductName = "Sumsung"},
            };
            products.Add(_product);
        }
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