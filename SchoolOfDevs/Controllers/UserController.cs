using Microsoft.AspNetCore.Mvc;
using SchoolOfDevs.Dto.User;
using SchoolOfDevs.Services;

namespace SchoolOfDevs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
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
        public async Task<IActionResult> Create([FromBody] UserRequest user)
        {
            return Ok(await _service.Create(user));
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest request)
        {
            return Ok(await _service.Authenticate(request));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UserRequestUpdate userIn, int id)
        {
            await _service.Update(userIn, id);
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