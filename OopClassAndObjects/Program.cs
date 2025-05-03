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
            
        }
    }
}