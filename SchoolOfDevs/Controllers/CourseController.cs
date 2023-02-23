using Microsoft.AspNetCore.Mvc;
using SchoolOfDevs.Dto.Course;
using SchoolOfDevs.Services;

namespace SchoolOfDevs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CourseRequest course)
        {
            return Ok(await _service.Create(course));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] CourseRequest courseIn, int id)
        {
            await _service.Update(courseIn, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }  
      
}