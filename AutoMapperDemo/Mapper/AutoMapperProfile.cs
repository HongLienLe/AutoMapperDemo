using System;
using AutoMapper;
using AutoMapperDemo.Model;

namespace AutoMapperDemo.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDTO, Employee>();
        }
    }
}
