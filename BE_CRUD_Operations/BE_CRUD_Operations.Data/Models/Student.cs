using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Data.Models
{
    public class Student
    {
        public string StudentId { get; set; }

        public string StudentName { get; set; }

        public string StudentCourse { get; set; }

        public Student()
        {
            //Generate a Unique GUID as the studentId
            StudentId = Guid.NewGuid().ToString();
        }
    }
}
