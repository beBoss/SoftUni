namespace Problem_3_PcCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PcCatalog
    {
        public static void Main()
        {
            var gamingPcComponents = new List<Component>
            {
                new Component("Motherboard", 350.17m, "Asus Maximum VIII Hero"),
                new Component("Processor", 540.35m, "Intel Core i7-6600K"),
                new Component("Memory", 170.60m, "G.Skill Ripjaws V Series DDR4 2666 (16GB)"),
                new Component("Graphics card", 250.32m, "MSI GTX 980 Ti Gaming 6G"),
                new Component("Primary storage", 360.27m, "Samsung 950 Pro M.2 SSD (256 GB)"),
                new Component("Secondary storage", 300, "Samsung 850 EVO (500GB)"),
                new Component("Disc drive", 60, "LG Blu-ray reader"),
                new Component("Power supply", 230.99m, "EVGA Supernova 850 watt G2 80 Plus Gold"),
                new Component("CPU cooler", 120, "Corsair H90"),
                new Component("Case", 180)
            };
            var pcGaming = new Computer("Gaming PC", gamingPcComponents);

            var homePcComponents = new List<Component>
            {
                new Component("Motherboard", 100, "AMD970"),
                new Component("Processor", 150, "AMD FX-6300 /3.5G/X6/BOX AM3+"),
                new Component("Memory", 95, "4GB DDR III 1600Mhz"),
                new Component("Graphics card", 170, "GEFORCE GT730 2GB DDR 3"),
                new Component("Primary storage", 142.20m, "500GB 7200 rpm SATA III 32c"),
                new Component("Disc drive", 45, "DVD-RWR 22x DualLayer"),
                new Component("Power supply", 86.60m, "ATX MidiTower CM K250 500W 120MM"),
                new Component("Case", 40)
            };
            var homePc = new Computer("Home PC", homePcComponents);

            var laptopPcComponents = new List<Component>
            {
                new Component("CPU", 450, "Intel Core i7-6700HQ"),
                new Component("RAM", 172, "16GB DDR4"),
                new Component("Graphics card", 230, "NVIDIA GeForce GTX 960M (4GB GDDR5)"),
                new Component("Primary storage", 137.60m, "1TB HDD"),
                new Component("Secondary storage", 186, "256GB SSD"),
                new Component("Disc drive", 45)
            };
            var laptopPc = new Computer("IdeaPad Y700", laptopPcComponents);

            var catalog = new List<Computer> { pcGaming, homePc, laptopPc };
            var sortCatalog = catalog.OrderBy(computer => computer.Price);

            foreach (var computer in sortCatalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
