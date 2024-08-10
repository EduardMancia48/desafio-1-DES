using AutoMapper;
using EmployeeManagement.Core.DTOs;
using EmployeeManagement.Core.Models;

namespace EmployeeManagement.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
