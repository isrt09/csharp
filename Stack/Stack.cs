
namespace StackCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // define stacks 
            Stack<int> numbers = new Stack<int>();            

            // add values
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            numbers.Push(40);

            // print all values in stack collections
            foreach (int number in numbers)
            {
                Console.WriteLine("Number item : {0}", number);
            }
        }
    }
}