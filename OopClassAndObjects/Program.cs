using ClassLibraryProj;

namespace Programs
{
    class Sample
    {
        public static void Main(string[] args)
        {
            Customer Arun = new Customer();//creating object  [all fields are initialized with default values inside the new object]
            Arun.Id = 109;
            Console.WriteLine("customerName=>"+ Arun.Name+"end");// null
            Console.WriteLine("customer grade=>"+ Arun.grade+"end");// '\0'
            Console.WriteLine("cus Id=>"+ Arun.Id);//109
            Console.WriteLine(Arun.getCustomerId());//109  //access methods using current object

            Arun.address = new Address();//creating object of Address class and assigning it to the address field of customer object
            Arun.address.houseNo = 123;
            Arun.address.streetName = "Main Street";
            Console.WriteLine("customer address houseNo=>" + Arun.address.houseNo);//123
            Console.WriteLine("customer address streetName=>" + Arun.address.streetName);//Main Street

            Customer kumar = null; //assigned with default value in reference type variable[ie local variable of main Method]
            System.Console.WriteLine("customer2=>" + kumar + "end");// null
            //System.Console.WriteLine("customer2 Id=>" + kumar.Id);// Null reference exception because kumar is null and we are trying to access the Id field of a null object

        }
    }
}