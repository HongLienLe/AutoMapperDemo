using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoMapperDemo.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public Employee Get()
        {
            var employeeDTO = new EmployeeDTO()
            {
                Name = "Hong",
                Salary = 1000000,
                Address = "Address",
                Department = "Software Developer"
            };

            return _mapper.Map<Employee>(employeeDTO);
        }
    }
}
