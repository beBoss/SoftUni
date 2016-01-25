namespace Problem_4_SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Problem_4_SoftwareUniversityLearningSystem.Students;
    using Problem_4_SoftwareUniversityLearningSystem.Trainers;

    public class SULSTest
    {
        public static void Main()
        {
            var juniorTrainer = new JuniorTrainer("Peter", "Petrov", 19);
            var seniorTrainer = new SeniorTrainer("Ivan", "Ivanov", 23);
            Console.WriteLine(juniorTrainer);
            Console.WriteLine(seniorTrainer);
            Console.WriteLine(juniorTrainer.CreateCourse("Advanced C#"));
            Console.WriteLine(seniorTrainer.CreateCourse("Java Basics"));
            Console.WriteLine(seniorTrainer.DeleteCourse("Advanced C#"));
            Console.WriteLine();

            var dropoutStudent = new DropoutStudent("Dvoikar", "Dvoikarov", 21, "123456789", 2.45, "Low scores");
            Console.WriteLine(dropoutStudent.Reapply());
            Console.WriteLine();

            var members = new List<Person>
            {
                new JuniorTrainer("Dimitur", "Petrov", 22),
                new SeniorTrainer("Ivailo", "Stanimirov", 30),
                new DropoutStudent("Vasil", "Rachkov", 18, "111111111", 2.9, "Bad behavior"),
                new GraduateStudent("Atanas", "Andreev", 21, "222222222", 4.75),
                new GraduateStudent("Stanimir", "Georgiev", 24, "333333333", 3.45),
                new OnlineStudent("Katq", "Iordanova", 28, "444444444", 5.50, "Advanced C#"),
                new OnlineStudent("Milka", "Vasileva", 35, "555555555", 5.20, "Java Basics"),
                new OnsiteStudent("Jivko", "Todorov", 19, "666666666", 3.28, "Advanced C#", 30),
                new OnsiteStudent("Hristian", "Filipinov", 27, "777777777", 6, "Advanced C#", 53)
            };

            var sortedStudents = members.Where(s => s is CurrentStudent)
                    .Cast<CurrentStudent>()
                    .OrderBy(s => s.AverageGrade);

            Console.WriteLine("Current students sorted by average grade:");
            Console.WriteLine();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
