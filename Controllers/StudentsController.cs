using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3APBD.Models;
using Microsoft.AspNetCore.Mvc;
using Cw3APBD.DAL;

namespace Cw3APBD.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService){
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudent(string orderBy){
            return Ok(_dbService.GetStudents());
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student){
            student.IndexNumber = $"s{new Random().Next(1,20000)}";
            return Ok(student);
        }
        [HttpPut]
        public string ActStudent(string id){

            return 200 + " Aktualizacja dokończona";
        }
        [HttpDelete]
        public string DelStudent(string id){
            return 200 + " Usuwanie dokończone";
        }
    }
}