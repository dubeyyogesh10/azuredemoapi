using azuredemoapi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azuredemoapi.Controllers
{
    [ApiController]
    [Route("/api/course")]
    public class CourseController : ControllerBase
    {

        private CourseService _cs;

        public CourseController(CourseService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_cs.GetCourses());
        }
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
