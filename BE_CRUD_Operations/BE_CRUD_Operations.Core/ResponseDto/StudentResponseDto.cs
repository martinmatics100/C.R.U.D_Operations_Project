using BE_CRUD_Operations.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Core.ResponseDto
{
    public class StudentResponseDto
    {
        public string StudentId { get; set; }
        public StudentDTO StudentDTO { get; set; }
    }
}
