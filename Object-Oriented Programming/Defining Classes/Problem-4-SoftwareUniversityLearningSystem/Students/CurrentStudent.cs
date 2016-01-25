namespace Problem_4_SoftwareUniversityLearningSystem.Students
{
    using System;

    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Current course cannot be empty!");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Current course : {this.CurrentCourse}\r\n";
        }
    }
}
