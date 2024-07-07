namespace NullHandling
{
    public class Person
    {
        // fields are value type which is non-nullable
        public int drivingLicenseNo; 
        public int tradeLicenseNo;

        public int mobileNumber;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(){
                drivingLicenseNo = 100111216,
                tradeLicenseNo = 10011985,
                mobileNumber = null, // This is compile error due to non-nullable issue
            };
        }
    }
}