using Aureum.Pass.DTOs;
using Aureum.Pass.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aureum.Pass.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AuthController : ControllerBase
    {

        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            this._service = service;
        }

        [HttpPost]
        public async Task<ActionResult<ReadAuthDTO>> Post([FromBody] CreateUserDTO createUserDTO)
        {
            ReadAuthDTO dto = await this._service.Register(createUserDTO);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<DataTokenDTO>> PostLogin([FromBody] AuthUserLoginDTO userLoginDTO)
        {
            DataTokenDTO dto = await _service.Login(userLoginDTO);
            return Ok(dto);
        }


        [HttpGet]
        [Authorize]
        public ActionResult<ReadAuthDTO> GetById()
        {
            return Ok("acesso");
        }






    }
}
