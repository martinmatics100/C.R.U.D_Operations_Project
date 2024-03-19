using AutoMapper;
using BE_CRUD_Operations.Core.Dto;
using BE_CRUD_Operations.Data.Models;

namespace BE_CRUD_Operations.MappinFolder
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDTO, Student>();  // Mapping from DTO to entity
            CreateMap<Student, StudentDTO>();  // Mapping from entity to DTO
        }
    }
}
