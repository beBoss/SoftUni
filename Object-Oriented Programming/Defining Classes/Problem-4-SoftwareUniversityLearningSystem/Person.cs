namespace Problem_4_SoftwareUniversityLearningSystem
{
    using System;

    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty!");
                }

                this.lastName = value;
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
                if (value < 0 || value > 115)
                {
                    throw new ArgumentOutOfRangeException("Wrong age!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            var value = $"First name: {this.FirstName}\r\nLast name: {this.LastName}\r\nAge: {this.Age}\r\n";

            return value;
        }
    }
}
