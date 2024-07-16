namespace Association
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        // Association Relationship (HAS-A)
        public Course course { get; set; }

        public Student(int studentId, string studentName)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }
    }

    public class Course
    {
        public int CourseCode { get; set; }
        public string? CourseName { get; set; }
        public Course(int courseCode, string? courseName)
        {
            this.CourseCode = courseCode;
            this.CourseName = courseName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(100142, "James Smith");
            student.course = new Course(101,"Accounting");
            Console.WriteLine($"Student Name : {student.StudentName}, Course Code : {student.course.CourseCode}, Course Name : {student.course.CourseName}");
        }
    }
}