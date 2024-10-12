namespace Dependency_Injection_Pratik.Services
{
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}