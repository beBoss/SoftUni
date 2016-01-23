namespace Problem_2_LaptopShop
{
    using System;

    public class LaptopShop
    {
        public static void Main()
        {
            Laptop beBossLaptop = new Laptop("Ideapad", 2253.20M);
            Laptop beBossNewLaptop = new Laptop(
                "Ideapad Y510P", 
                "Lenovo",
                "Intel Core i7",
                16, 
                "NVIDIA GeForce GT 755M", 
                1024, 
                "15 inch", 
                new Battery(BatteryType.LiIon, 4, 2345, 3.5d),
                3652.01M);

            Console.WriteLine(beBossLaptop);
            Console.WriteLine(beBossNewLaptop);
        }
    }
}
