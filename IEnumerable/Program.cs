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