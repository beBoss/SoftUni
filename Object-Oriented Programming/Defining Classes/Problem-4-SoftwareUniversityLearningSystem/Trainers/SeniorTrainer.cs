namespace Problem_4_SoftwareUniversityLearningSystem.Trainers
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public string DeleteCourse(string courseName) => $"Course {courseName} has been deleted.";
    }
}
