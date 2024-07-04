using BuilderPattern.Services.Abstractions;
using BuilderPattern.Services.Implementations;
using BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        IMentorshipProgramBuilder builder = new MentorshipProgramBuilder();
        MentorshipProgramDirector director = new MentorshipProgramDirector(builder);

        var pairs = new List<(string student, string mentor)>
        {
            ("Alice", "Mentor1"),
            ("Bob", "Mentor2"),
            ("Captain", "Mentor3")
        };

        director.ConstructProgram("STEM Mentorship Program", new DateTime(2024, 7, 1), new DateTime(2024, 12, 31), pairs);
        MentorshipProgram program = director.GetProgram();

        Console.WriteLine(program.ToString());
    }
}
