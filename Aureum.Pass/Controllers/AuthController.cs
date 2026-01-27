using Aureum.Pass.Data;
using Aureum.Pass.DTOs;
using Aureum.Pass.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace Aureum.Pass.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthContext _context;
        private readonly AuthProfile _mapper;

        public AuthController(AuthContext context, AuthProfile mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpPost]
        public ActionResult<ReadAuthDTO> Post([FromBody] CreateUserDTO createUserDTO)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<ReadAuthDTO> Get([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            skip = Math.Max(skip, 0);
            take = Math.Clamp(take, 1, 100);
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<ReadAuthDTO> GetById(long id)
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
