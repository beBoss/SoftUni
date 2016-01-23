namespace Problem_2_LaptopShop
{
    using System;

    public class Battery
    {
        private int batteryCapacity;

        private double batteryLife;
 
        public Battery(
            BatteryType batteryType,
            byte cells, 
            int batteryCapacity, 
            double batteryLife)
        {
            this.BatteryType = batteryType;
            this.Cells = cells;
            this.BatteryCapacity = batteryCapacity;
            this.BatteryLife = batteryLife;
        }

        public BatteryType BatteryType { get; set; }

        public byte Cells { get; set; }

        public int BatteryCapacity
        {
            get{ return this.batteryCapacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery capacity cannot be negative!");
                }
                this.batteryCapacity = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be negative");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string result =  $"{this.BatteryType}, {this.Cells}-cells, {this.batteryCapacity} mAh" + "\n";
            result += $"battery life: {this.batteryLife} hours";

            return result;
        }
    }
}
