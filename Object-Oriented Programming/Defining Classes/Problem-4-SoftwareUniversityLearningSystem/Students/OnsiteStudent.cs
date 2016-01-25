namespace Problem_4_SoftwareUniversityLearningSystem.Students
{
    using System;

    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(
            string firstName, 
            string lastName, 
            int age, 
            string studentNumber, 
            double averageGrade, 
            string currentCourse, 
            int numberOfVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Visits cannot be negaative!");
                }

                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += $"Number of visits: {this.NumberOfVisits}\r\n";

            return result;
        }
    }
}
