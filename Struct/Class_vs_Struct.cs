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

            shape2 = shape1; // structure copy value one from another
            shape2.height = 300;
            shape2.width = 400;

            
            Rectangle rectangle1 = new Rectangle(); // object heap value type
            
            rectangle1.width = 75;
            rectangle1.height = 55;

            rectangle2 = rectangle1; // object  copy value one from another
            rectangle2.height = 80;
            rectangle2.width = 95;
            
            Console.WriteLine("Shape 1 Height and Width : " + shape1.height, shape1.width);
            Console.WriteLine("Shape 2 Height and Width : " + shape2.height, shape2.width);    
            Console.WriteLine("===========================================================");
            Console.WriteLine("Rectangle 1 Height and Width : " + rectangle1.height, rectangle1.width);            
            Console.WriteLine("Rectangle 2 Height and Width : " + rectangle2.height, rectangle2.width);
        }
    }
}