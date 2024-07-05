namespace ReadOnly
{
    public readonly struct Student
    {
        public readonly int _studentID;
        public readonly string _studentName;

        public Student(int studentId, string studentName)
        {
            _studentID = studentId;
            _studentName = studentName;
        }

        public string GetName
        {
            get { return _studentName; } // Only allow for get accessor using read-only structure; no set property
        } 

        public void StudentDetails()
        {
            Console.WriteLine(this.GetName);            
        }
    }


    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            Student student = new Student(2001, "James Smith");            
            Console.WriteLine("Student ID : {0} and Name : {1}",student._studentID, student._studentName);
            student.StudentDetails();
            Console.WriteLine(student.GetName);
        }
    }
}