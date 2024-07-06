namespace BoxingUnboxing
{
    class Program
    {
        class Product
        {
            public int _productCode { get; set; }
        }
        static void Main(string[] args)
        {
            //  reference Type to value Type (Unboxing)
            Object _product = 1001; // object reference type
            int _productCode = (int)_product; // () typecasting symbol
            
            
            // value type to reference type (Boxing)
            int _category = 2001;
            Object _categoryCode = _category;            

            // Result output
            Console.WriteLine(_product);
            Console.WriteLine(_productCode);
            Console.WriteLine("==================");
            Console.WriteLine(_category);
            Console.WriteLine(_categoryCode);

            
        }
    }
}