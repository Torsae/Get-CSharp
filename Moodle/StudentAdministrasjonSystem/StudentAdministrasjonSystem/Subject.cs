namespace StudentAdministrationSystem
{
    internal class Subject(int subjectId, string subjectName, int studyPoints)
    {
        public int SubjectId { get; set; } = subjectId;
        public string? SubjectName { get; set; } = subjectName;
        public int StudyPoints { get; set; } = studyPoints;

        public void PrintInfo()
        {
            Console.WriteLine("Subject name: " + SubjectName + "\n" +
                              "Study points: " + StudyPoints + "\n");
        }
    }
}
