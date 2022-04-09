using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Entities;
using WebAPI.Helpers;
using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.UnitOfWork;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork, ILogger<StudentController> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //[HttpGet("students/all")]
        //public async Task<object> GetStudents()
        //{
        //    var list = await _studentDbContext.Students.Include(x => x.StudentCourses)
        //        .Select(x => new
        //        {
        //            x.FirstName,
        //            x.LastName,
        //            x.DateOfBirth,
        //            x.Salary,
        //            Courses = x.StudentCourses.Select(x => new
        //            {
        //                x.Course.Name,
        //                x.Course.CreationTime
        //            })
        //        })
        //        .ToListAsync();

        //    return list;
        //}

        //[HttpGet("studentcourses/all")]
        //public async Task<object> GetStudentCourses()
        //{
        //    var list = await _studentDbContext.StudentCourses.Include(x => x.Student)
        //        .Select(x => new
        //        {
        //            x.Student.FirstName,
        //            x.Student.LastName,
        //            x.Student.DateOfBirth,
        //            x.Student.Salary,
        //            x.Course.Name,
        //            x.StartDate,
        //            x.EndDate
        //        })
        //        .ToListAsync();

        //    return list;
        //}

        [HttpGet("students/getall")]
        //[MyCustomAttributeForAuthorize]
        public async Task<object> GetStudents()
        {
            _logger.LogDebug($"Function of get all students was called successfully on {DateTime.Now}.");

            var list = await _unitOfWork.StudentRepository.GetAllList();

            return list;
        }

        [HttpGet("student/{id}")]
        [Authorize("StudentUpdatePolicy")]
        public async Task<IActionResult> GetStudent(int id)
        {
            _logger.LogDebug($"Function of get student with id parameter was called successfully on {DateTime.Now}.");

            var student = await _unitOfWork.StudentRepository.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost("students/create")]
        public async Task<IActionResult> CreateStudent([FromBody] StudentDto studentDto)
        {
            _logger.LogInformation($"Function of create student was called successfully on {DateTime.Now}.");

            var student = new Student
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                DateOfBirth = studentDto.DateOfBirth,
                Salary = studentDto.Salary
            };

            await _unitOfWork.StudentRepository.Add(student);

            await _unitOfWork.Commit();

            return Created($"api/student/{student.Id}", student);
        }

        [HttpPut("students/update")]
        [Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<Student> UpdateStudent(int id, StudentDto studentDto)
        {
            _logger.LogInformation($"Function of update student was called  successfully on {DateTime.Now}.");

            var student = await _unitOfWork.StudentRepository.Find(id);

            student.FirstName = studentDto.FirstName;
            student.LastName = studentDto.LastName;
            student.Salary = studentDto.Salary;

            await _unitOfWork.StudentRepository.Update(student);

            await _unitOfWork.Commit();

            return student;
        }

        [HttpDelete("students/delete")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            _logger.LogInformation($"Function of delete student was called successfully on {DateTime.Now}.");

            var student = await _unitOfWork.StudentRepository.Find(id);

            try
            {
                await _unitOfWork.StudentRepository.Delete(student);

                await _unitOfWork.Commit();

                return student;
            }
            catch (Exception exception)
            {
                _logger.LogError($"Error ocurred : {exception.Message}");
            }

            return BadRequest();
        }
    }
}
