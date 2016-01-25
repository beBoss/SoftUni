namespace Problem_4_SoftwareUniversityLearningSystem.Students
{
    using System;

    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(
            string firstName, 
            string lastName, 
            int age, 
            string studentNumber, 
            double averageGrade, 
            string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dropout reason cannot be empty!");
                }

                this.dropoutReason = value;
            }
        }

        public string Reapply()
        {
            var result = this.ToString();
            return result;
        }

        public override string ToString()
        {
            var result = base.ToString() + "Dropout reason: " + this.DropoutReason + "\r\n";

            return result;
        }
    }
}
