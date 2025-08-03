using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection_Pratik2.Managers;
using DependencyInjection_Pratik2.Services;

namespace DependencyInjection_Pratik2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Classroom _classroom;

        public ValuesController(Classroom classroom)
        {
            _classroom = classroom;
        }


        [HttpGet]
        public IActionResult GetTeacherInfo()
        {
            var teacherinfo = _classroom.GetTeacherInfo();
            return Ok(teacherinfo);
        }
    }
}
