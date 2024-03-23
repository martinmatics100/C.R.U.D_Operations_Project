using BE_CRUD_Operations.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Data.Models
{
    public class Student
    {
        public string StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public bool IsGraduated { get; set; }

        public Student()
        {
            StudentId = Guid.NewGuid().ToString();
        }
    }
}
