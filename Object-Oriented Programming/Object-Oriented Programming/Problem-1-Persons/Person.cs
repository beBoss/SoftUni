namespace Problem_1_Persons
{
    using System;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
            : this(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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
                    throw new ArgumentException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be between 1 and 100!");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                {
                    throw new ArgumentException("Email cannot be null, empty or not contains \"@\" ");
                }

                this.email = value;
            }
        }

        public void ToString()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Email: {2}", 
                this.name, this.age, this.email);
        }
    }
}
