using Dependency_Injection_Pratik.Services;

namespace Dependency_Injection_Pratik.Entities
{
    public class TeacherEntity :ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return FirstName + " " + LastName;
        }
    }
}
