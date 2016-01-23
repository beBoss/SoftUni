namespace Problem_1_Persons
{
    using System;

    public class Persons
    {
        public static void Main()
        {
            Person pesho = new Person("pesho", 20);
            Person gosho = new Person("gosho", 100, "gosho@gosho.com");
            Person ivan = new Person("ivan", 34, "ivan@ivan.com");

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(gosho.ToString());
            Console.WriteLine(ivan.ToString());
        }
    }
}
