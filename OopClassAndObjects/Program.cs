using ClassLibraryProj;

namespace Programs
{
    class Sample
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer();//creating object 
            customer.Id = 109;
            Console.WriteLine("customerName=>"+customer.Name);// null
            Console.WriteLine("customer grade=>"+customer.grade);// '\0'
            Console.WriteLine("cus Id=>"+customer.Id);//109
            Console.WriteLine(customer.getCustomerId());//109  //access methods using current object

            Customer c2=null;
            System.Console.WriteLine("customer2=>" + c2);// null

        }
    }
}