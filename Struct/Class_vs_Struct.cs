namespace StrucVsClass
{
    struct Shape
    {
        public int width, height;
    }

    class Rectangle
    {
        public int width, height;
    }  


    class Program
    {
        // Main Method
        static void Main()
        {
            Shape shape1;    //  reference stack value type
            
            shape1.width  = 100;
            shape1.height = 200;

            
            Rectangle rectangle1 = new Rectangle(); // object heap value type
            
            rectangle1.width = 75;
            rectangle1.height = 55;

            
            Console.WriteLine("Shape 1 Height and Width : " + shape1.height, shape1.width);
            Console.WriteLine("===========================================================");
            Console.WriteLine("Rectangle 1 Height and Width : " + rectangle1.height, rectangle1.width);            
        }
    }
}