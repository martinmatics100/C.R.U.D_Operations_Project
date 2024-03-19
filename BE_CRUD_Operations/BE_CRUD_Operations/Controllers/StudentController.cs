using BE_CRUD_Operations.Core.Dto;
using BE_CRUD_Operations.Core.Services;
using BE_CRUD_Operations.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BE_CRUD_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(string studentId)
        {
            try
            {
                var retrievedStudent = await _service.GetStudentById(studentId);

                if(retrievedStudent == null)
                {
                    return NotFound(ApiResponse.Failed($"Student with ID {studentId} not found."));
                }

                return Ok(ApiResponse.Success(retrievedStudent));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error retrieving student: {ex}");

                // If an unexpected exception occurs
                return StatusCode(500, ApiResponse.Failed("Internal Server Error: An unexpected error occurred."));
            }
        }


        [HttpGet("get-all-students")]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var students = await _service.GetAllStudents();
                
                if(students == null)
                {
                    return NotFound(ApiResponse.Failed("Fetching students failed"));
                }

                return Ok(ApiResponse.Success(students));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error retrieving students: {ex}");

                // If an unexpected exception occurs
                return StatusCode(500, ApiResponse.Failed("Internal Server Error: An unexpected error occurred."));
            }
        }

        
        [HttpPost("create-student")]
        public async Task<IActionResult> Post([FromBody] StudentDTO studentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ApiResponse.Failed("Invalid request"));
            }

            try
            {
                var createdStudent = await _service.CreateStudent(studentDTO);

                if(createdStudent)
                {
                    return Ok(ApiResponse.Success(studentDTO));
                }
                else
                {
                    return StatusCode(500, ApiResponse.Failed("Internal Server Error: Failed to create student."));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex}");

                // If an unexpected exception occurs
                return StatusCode(500, ApiResponse.Failed("Internal Server Error: An unexpected error occurred."));
            }
        }


        [HttpPut("update-student/{id}")]
        public async Task<IActionResult> Put(string studentId, StudentDTO updatedStudentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ApiResponse.Failed("Invalid request"));
            }

            try
            {
                var isUpdated = await _service.UpdateStudent(studentId, updatedStudentDTO);

                if (isUpdated)
                {
                    return Ok(ApiResponse.Success(updatedStudentDTO));
                }
                else
                {
                    return NotFound(ApiResponse.Failed($"Student with ID {studentId} not found."));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex}");

                // If an unexpected exception occurs
                return StatusCode(500, ApiResponse.Failed("Internal Server Error: An unexpected error occurred."));
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string studentId)
        {
            try
            {
                var isDeleted = await _service.DeleteStudentById(studentId);

                if(!isDeleted)
                {
                    return NotFound(ApiResponse.Failed($"Student with ID {studentId} not found."));
                }

                return Ok(ApiResponse.Success($"Student with ID {studentId} deleted successfully."));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ApiResponse.Failed("Internal Server Error: An unexpected error occurred."));
            }
        }
    }
}
