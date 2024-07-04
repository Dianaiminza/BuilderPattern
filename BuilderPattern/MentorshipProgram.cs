namespace BuilderPattern
{
    public class MentorshipProgram
    {
        public List<string> Students { get; set; }
        public List<string> Mentors { get; set; }
        public Dictionary<string, string> StudentMentorPairs { get; set; }
        public string ProgramName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MentorshipProgram()
        {
            Students = new List<string>();
            Mentors = new List<string>();
            StudentMentorPairs = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            var pairs = string.Join(", ", StudentMentorPairs.Select(kv => $"{kv.Key}-{kv.Value}"));
            return $"Program: {ProgramName}\n" +
                   $"Start Date: {StartDate.ToShortDateString()}\n" +
                   $"End Date: {EndDate.ToShortDateString()}\n" +
                   $"Pairs: {pairs}";
        }
    }

}
