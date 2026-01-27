using Aureum.Pass.Data;
using Aureum.Pass.DTOs;
using Aureum.Pass.Models;
using Aureum.Pass.Profiles;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Aureum.Pass.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<AuthUser> _userManager;

        public AuthController(AuthContext context, IMapper mapper, UserManager<AuthUser> userManager)
        {
            this._context = context;
            this._mapper = mapper;
            this._userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<ReadAuthDTO>> Post([FromBody] CreateUserDTO createUserDTO)
        {
            AuthUser authUser = this._mapper.Map<AuthUser>(createUserDTO);

            IdentityResult result = await _userManager.CreateAsync(authUser, createUserDTO.Password);

            if (result.Succeeded)
            {
                var dtoRead = _mapper.Map<ReadAuthDTO>(authUser);
                return CreatedAtAction(nameof(GetById), new { id = authUser.Id }, dtoRead);
            }
            return BadRequest(result.Errors);
        }

        [HttpGet]
        public ActionResult<ReadAuthDTO> Get([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            skip = Math.Max(skip, 0);
            take = Math.Clamp(take, 1, 100);
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<ReadAuthDTO> GetById(string id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] PutAuthDTO putAuthDTO)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("{id}")]
        public ActionResult Patch(long id, [FromBody] PatchAuthDTO patchAuthDTO)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            throw new NotImplementedException();
        }

    }
}
