namespace BuilderPattern.Services.Abstractions
{
    public interface IMentorshipProgramBuilder
    {
        void SetProgramName(string name);
        void SetDates(DateTime start, DateTime end);
        void AddStudent(string student);
        void AddMentor(string mentor);
        void PairStudentWithMentor(string student, string mentor);
        MentorshipProgram GetProgram();
    }
}
