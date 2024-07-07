namespace NullHandling
{
    public class Person
    {
        // fields are value type which is non-nullable
        public int drivingLicenseNo; 
        // make it nullable 
        public Nullable<int> tradeLicenseNo;        
        public Nullable<int> mobileNumber;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(){
                drivingLicenseNo = 100111216,
                tradeLicenseNo = 10011985,
                mobileNumber = null, // fixed compile error
            };

            if(person.tradeLicenseNo.HasValue)
            {
                if(person.mobileNumber == null)
                {
                    Console.WriteLine("Person Driving License No : {0}", person.drivingLicenseNo.ToString());
                }
            }
        }
    }
}