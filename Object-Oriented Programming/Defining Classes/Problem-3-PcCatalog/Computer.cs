namespace Problem_3_PcCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class Computer
    {
        private string name;
        
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Computer must have components!");
                }

                this.components = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Price => this.CalculatePrices();

        private decimal CalculatePrices()
        {
                var allComponents = this.components;
                decimal price = allComponents.Sum(component => component.Price);

                return price;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            var result = new StringBuilder();
            result.AppendLine($"Computer name: {this.Name}");

            foreach (var component in this.components)
            {
                result.AppendLine(value: 
                    string.Format("{0}{2} {1:c2}", 
                    component.Name, 
                    component.Price, 
                    string.IsNullOrWhiteSpace(component.Details) ? ":" : ":" + " " + component.Details + ":"));
            }

            result.AppendLine($"Total price: {this.Price:c2}");
            return result.ToString();
        }
    }
}
