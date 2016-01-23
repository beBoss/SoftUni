namespace Problem_2_LaptopShop
{
    using System;

    public class Laptop
    {
        private string model;

        private string manufacturer;

        private string processor;

        private int ram;

        private string graphicsCard;

        private int hdd;

        private string screen;

        private Battery battery;

        private Battery batteryLife;

        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.model = model;
            this.price = price;
        }

        public Laptop(
            string model, 
            string manufacturer,
            string processor,
            int ram, 
            string graphicsCard, 
            int hdd,
            string screen,
            Battery battery,
            decimal price) : this(model, price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public string Model
        {
            get{ return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be Empty!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be Empty!");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get{ return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processor cannot be empty!");
                }

                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Ram cannot be negaive!");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Graphics card cannot be empty!");
                }

                this.graphicsCard = value;
            }
        }

        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Hdd cannot be negaive!");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen cannot be empty!");
                }

                this.screen = value;
            }
        }

        public Battery Battery
        {
            get{ return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Price cannot be negaive!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            if (this.manufacturer == null)
            {
                string laptop = "model: " + this.model + "\n";
                laptop += "price: " + this.price + " lv. \n";

                return laptop;
            }
            else
            {
                string laptop = "model: " + this.model + "\n";
                laptop += "manufacturer: " + this.manufacturer + "\n";
                laptop += "processor: " + this.processor + "\n"; ;
                laptop += "RAM: " + this.Ram + " GB \n";
                laptop += "graphics card: " + this.graphicsCard + "\n";
                laptop += "HDD: " + this.Hdd + " GB SSD \n";
                laptop += "screen: " + this.screen + "\n";
                laptop += "battery: " + this.battery + "\n";
                laptop += "price: " + this.price + " lv. \n";

                return laptop;
            }
        }
    }
}
