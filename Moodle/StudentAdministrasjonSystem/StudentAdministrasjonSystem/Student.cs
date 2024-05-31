namespace StudentAdministrationSystem
{
    internal class Student(int id, string name, int age, string? studyProgramme)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string? StudyProgramme { get; set; } = studyProgramme;

        public void PrintInfo()
        {
            Console.WriteLine("Student id: " + Id +"\n" +
                              "Student name: " + Name + "\n" +
                              "Student age: " + Age + "\n" +
                              "Student study programme: " + StudyProgramme + "\n");
        }
    }
}