namespace Problem_4_SoftwareUniversityLearningSystem
{
    using System;

    public class Student : Person
    {
        private string studentNumber;

        private double averageGrade;

        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade) 
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student number cannot be empty!");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Average grade must be between 2 and 6!");
                }

                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() 
                + $"Role: {this.GetType().Name}\r\n"
                + $"Student number: {this.StudentNumber}\r\n" 
                + $"Average grade: {this.AverageGrade:F2}\r\n";
        }
    }
}
