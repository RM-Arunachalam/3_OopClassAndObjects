namespace ClassLibraryProj
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public char grade;

        public int getCustomerId()
        {
            return Id;
        }
    }
}
