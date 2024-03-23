using AutoMapper;
using BE_CRUD_Operations.Core.Dto;
using BE_CRUD_Operations.Core.Interfaces.IRepository;
using BE_CRUD_Operations.Core.Interfaces.IServices;

//using BE_CRUD_Operations.Core.Mapper;
using BE_CRUD_Operations.Data.Models;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Core.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IBaseRepository<Student> _baseRepository;
        private readonly IMapper _mapper;

        public StudentService(IBaseRepository<Student> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateStudent(StudentDTO studentDTO)
        {
            try
            {

                var student = _mapper.Map<Student>(studentDTO);

                if(student == null)
                {
                    return false;
                }
                await _baseRepository.AddAsync(student);

                var createdStudentId = student.StudentId.ToString();

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while creating a student: {ex.Message}"); 

                return false;
            }
        }

        public async Task<bool> DeleteStudentById(string studentId)
        {
            try
            {
                var studentToDelete = await _baseRepository.GetByIdAsync(studentId);

                if (studentToDelete == null)
                    return false;

                await _baseRepository.DeleteAsync(studentToDelete);

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occurred while deleting student with ID {studentId}: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<StudentDTO>> GetAllStudents()
        {
            var students = await _baseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<StudentDTO>>(students);
        }

        public async Task<StudentDTO> GetStudentById(string studentId)
        {
            try
            {
                var gottenStudent = await _baseRepository.GetByIdAsync(studentId);

                if (gottenStudent == null)
                    return null;

                return _mapper.Map<StudentDTO>(gottenStudent);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occurred while fetching student with ID {studentId}: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateStudent(string studentId, StudentDTO updatedStudentDTO)
        {
            try
            {
                var existingStudent = await _baseRepository.GetByIdAsync(studentId);

                if(existingStudent == null)
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                    return false;
                }

                _mapper.Map(updatedStudentDTO, existingStudent);
                await _baseRepository.UpdateAsync(existingStudent);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while updating student with ID {studentId}: {ex.Message}");
                return false;
            }
        }
    }
}
