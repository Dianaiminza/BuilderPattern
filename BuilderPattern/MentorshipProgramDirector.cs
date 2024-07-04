using BuilderPattern.Services.Abstractions;

namespace BuilderPattern
{
    public class MentorshipProgramDirector
    {
        private readonly IMentorshipProgramBuilder _programBuilder;

        public MentorshipProgramDirector(IMentorshipProgramBuilder programBuilder)
        {
            _programBuilder = programBuilder;
        }

        public void ConstructProgram(string name, DateTime start, DateTime end, List<(string student, string mentor)> pairs)
        {
            _programBuilder.SetProgramName(name);
            _programBuilder.SetDates(start, end);

            foreach (var pair in pairs)
            {
                _programBuilder.AddStudent(pair.student);
                _programBuilder.AddMentor(pair.mentor);
                _programBuilder.PairStudentWithMentor(pair.student, pair.mentor);
            }
        }

        public MentorshipProgram GetProgram()
        {
            return _programBuilder.GetProgram();
        }
    }

}
