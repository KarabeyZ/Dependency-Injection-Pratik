using Dependency_Injection_Pratik.Services;

namespace Dependency_Injection_Pratik.Entities
{
    public class ClassRoomEntity
    {
        private readonly ITeacher _teacher;

        public ClassRoomEntity(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
