using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_monitoring_dashboard.Data;

namespace student_monitoring_dashboard.Controllers
{   
    [Produces("application/json")]
    [Route("api/Teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly DashContext _context;

        public TeacherController(DashContext context)
        {
            _context = context;
        }
        
        // public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        // {
        //     return Ok(await _context.Courses.ToListAsync());

        // }
        [HttpGet]
        public IEnumerable<Teacher> GetTeacher()
        {
            return _context.Teacher;
        }
    }
}
