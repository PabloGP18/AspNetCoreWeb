using AspNetCoreWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentsController : Controller
    {
        private List<Student> _students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pgp", Roll = 1001 },
            new Student() { Id = 2, Name = "Zidane", Roll = 1002 },
            new Student() { Id = 3, Name = "Cristiano", Roll = 1003 },
            new Student() { Id = 4, Name = "Messi", Roll = 1004 },
            new Student() { Id = 5, Name = "Raul", Roll = 1005 },
            new Student() { Id = 6, Name = "Beckham", Roll = 1006 },
            new Student() { Id = 7, Name = "Kluivert", Roll = 1007 },
        };

        // This is the web API that will call ALL students
        [HttpGet]
        
        public IActionResult Gets()
        {
            // errorhandling if no students are found
            if (_students.Count == 0)
            {
                return NotFound("No list found");
            }
            // students found -> return them
            return Ok(_students);
        }
        
        
        // API that return student by student's ID
        [HttpGet("GetStudent")]
        
        public IActionResult Get(int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id);
            
            // errorhandling if no student by id is found
            if (student == null)
            {
                return NotFound("No student found");
            }

            return Ok(student);
        }


        [HttpPost]
        // The api will save the student here
        public IActionResult Save(Student student)
        {
            _students.Add(student);

            if (_students.Count == 0)
            {
                return NotFound("No list found.");
            }

            return Ok(_students);
        }
        

        [HttpDelete]
        // Api for deleting student by id
        public IActionResult DeleteStudent(int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id);

            if (student == null)
            {
                return NotFound("No student found.");
            }
            _students.Remove(student);

            if (_students.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_students);
        }
    }
    
}