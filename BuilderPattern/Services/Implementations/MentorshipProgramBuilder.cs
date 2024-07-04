using BuilderPattern.Services.Abstractions;

namespace BuilderPattern.Services.Implementations
{
    public class MentorshipProgramBuilder : IMentorshipProgramBuilder
    {
        private MentorshipProgram _program;

        public MentorshipProgramBuilder()
        {
            _program = new MentorshipProgram();
        }

        public void SetProgramName(string name)
        {
            _program.ProgramName = name;
        }

        public void SetDates(DateTime start, DateTime end)
        {
            _program.StartDate = start;
            _program.EndDate = end;
        }

        public void AddStudent(string student)
        {
            _program.Students.Add(student);
        }

        public void AddMentor(string mentor)
        {
            _program.Mentors.Add(mentor);
        }

        public void PairStudentWithMentor(string student, string mentor)
        {
            _program.StudentMentorPairs[student] = mentor;
        }

        public MentorshipProgram GetProgram()
        {
            return _program;
        }
    }

}
