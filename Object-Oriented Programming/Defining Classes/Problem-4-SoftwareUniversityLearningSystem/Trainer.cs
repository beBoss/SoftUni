namespace Problem_4_SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public string CreateCourse(string courseName) => $"Course {courseName} has been created.";

        public override string ToString()
        {
            string result = base.ToString() 
                + $"Role: {this.GetType().Name}\n\r";

            return result;
        }
    }
}
