namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatContact c1 = new CreatContact();
            String[] names = {"Sagar","Krishna","Pankaj","Dharani"};
            c1.change(names);
        }
    
    }
}