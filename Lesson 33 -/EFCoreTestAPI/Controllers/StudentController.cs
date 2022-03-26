using EFCoreTestAPI.Data;
using EFCoreTestAPI.Data.Entities;
using EFCoreTestAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentRepository studentRepository, ILogger<StudentController> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        [HttpGet("students")]
        public async Task<object> GetStudents()
        {
            _logger.LogError("hello jsaghd");

            var data = await _studentRepository.GetAll();

            return data;
        }

        //[HttpGet("students")]
        //public async Task<object> GetStudents()
        //{
        //    var list = await _studentDBContext.Students.Include(x => x.StudentCourses).Select(s => new
        //    {
        //        s.Id,
        //        s.FirstName,
        //        s.LastName,
        //        StudentCourses = s.StudentCourses.Select(x => new
        //        {
        //            x.StudentId,
        //            x.CourseId
        //        })
        //    }).ToListAsync();

        //    return list;
        //}

        //[HttpGet("reports")]
        //public async Task<object> GetReport()
        //{
        //    var query = from sc in _studentDBContext.StudentCourses
        //                join s in _studentDBContext.Students on sc.StudentId equals s.Id
        //                join c in _studentDBContext.Courses on sc.CourseId equals c.Id
        //                select new
        //                {
        //                    s.FirstName,
        //                    s.LastName,
        //                    c.Name,
        //                    sc.StudentId,
        //                    sc.CourseId
        //                };

        //    return await query.ToListAsync();
        //}

        [HttpGet("student/{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await _studentRepository.GetStudentById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateStudent([FromBody] Student student)
        {
            await _studentRepository.CreateStudent(student);

            return Created($"/api/student/{student.Id}", student);
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateStudent(int id, [FromBody] Student newStudent)
        {
            var student = await _studentRepository.GetStudentById(id);
            student.FirstName = newStudent.FirstName;
            student.LastName = newStudent.LastName;

            await _studentRepository.UpdateStudent(id, student);

            return Ok(student);
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var deletedStudent = await _studentRepository.DeleteStudent(id);

            return Ok(deletedStudent);
        }
    }
}
