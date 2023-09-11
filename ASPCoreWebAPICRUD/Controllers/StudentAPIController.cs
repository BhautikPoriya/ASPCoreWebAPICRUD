using ASPCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ASPCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly CodeFirstDBContext codeFirst;

        public StudentAPIController(CodeFirstDBContext codeFirst) 
        {
            this.codeFirst = codeFirst;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await codeFirst.Students.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentsbyID(int id)
        {
            var data = await codeFirst.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return data; 
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student std)
        {
            await codeFirst.Students.AddAsync(std);
            await codeFirst.SaveChangesAsync();
            return Ok(std);
        }


    }
}
