using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using studentGitApi.Model;

namespace studentGitApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public AppDbContext _context;
        public StudentController(AppDbContext context) {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Student std) {
            _context.Students.Add(std);
            _context.SaveChanges();
            return Ok(std);
        }
        
    }
}
