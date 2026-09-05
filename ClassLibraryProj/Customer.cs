namespace ClassLibraryProj
{
    public class Customer
    {
        public int Id;
        public string Name;

        public char grade;

        public Address address;//Ref variables can be fields
        public int getCustomerId()
        {
            return Id;
        }
    }
}
