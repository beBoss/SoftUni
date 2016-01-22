namespace Problem_1_Persons
{
    public class Persons
    {
        public static void Main()
        {
            Person pesho = new Person("pesho", 20);
            Person gosho = new Person("gosho", 100, "gosho@gosho.com");
            Person ivan = new Person("ivan", 34, "ivan@ivan.com");

            pesho.ToString();
            gosho.ToString();
            ivan.ToString();
        }
    }
}
