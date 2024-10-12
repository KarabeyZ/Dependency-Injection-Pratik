using Dependency_Injection_Pratik.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Pratik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public HomeController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var teacherInfo = _teacher.GetInfo();
            return Ok(teacherInfo);
        }
    }
}
