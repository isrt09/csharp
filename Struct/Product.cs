namespace StructureProgram
{
    struct Product
    {
        private int _productID;
        private string  _productName;

        // Struct with constructor
        public Product(int productID, string productName)
        {
            _productID = productID;
            _productName = productName;
        }

        public int ProductID
        {
            set { _productID = value; }
            get { return _productID; }
        }

        public string ProductName
        {
            set { _productName = value;}
            get { return _productName; }
        }
    }    
}