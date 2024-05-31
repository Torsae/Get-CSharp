namespace StudentAdministrationSystem
{
    internal class Grade (Student student, Subject subject)
    {
        public string Name { get; set; } = student.Name;
        public string? SubjectName { get; set; } = subject.SubjectName;
        public int StudyPoints { get; set; } = subject.StudyPoints;
        public void PrintInfo()
        {
            Console.WriteLine("Student name: " + Name + "\n" +
                              "Subject: " + SubjectName + "\n" +
                              "Study points: " + StudyPoints + "\n");
        }
    }
}
