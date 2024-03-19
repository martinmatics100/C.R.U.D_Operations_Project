using BE_CRUD_Operations.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Core.Services
{
    public interface IStudentService
    {
        Task<bool> CreateStudent(StudentDTO studentDTO);

        Task<bool> UpdateStudent(string studentId, StudentDTO updatedStudentDTO);

        Task<IEnumerable<StudentDTO>> GetAllStudents();

        Task<StudentDTO> GetStudentById(string studentId);

        Task<bool> DeleteStudentById(string studentId);
    }
}
