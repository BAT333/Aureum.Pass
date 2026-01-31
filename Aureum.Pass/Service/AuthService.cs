using Aureum.Pass.Data;
using Aureum.Pass.DTOs;
using Aureum.Pass.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Aureum.Pass.Service
{
    public class AuthService
    {
        private readonly AuthContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<AuthUser> _userManager;
        private readonly SignInManager<AuthUser> _signInManager;
        private readonly TokenService _tokenService;

        public AuthService(AuthContext context, IMapper mapper, UserManager<AuthUser> userManager, SignInManager<AuthUser> signInManager, TokenService tokenService)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<ReadAuthDTO> Register(CreateUserDTO dto)
        {
            AuthUser authUser = this._mapper.Map<AuthUser>(dto);

            IdentityResult result = await _userManager.CreateAsync(authUser, dto.Password);

            if (result.Succeeded)
            {
                return _mapper.Map<ReadAuthDTO>(authUser);
            }
            throw new ApplicationException("User registration failed!");
        }

        public async Task<DataTokenDTO> Login(AuthUserLoginDTO userLoginDTO)
        {
            SignInResult inResult = await this._signInManager.PasswordSignInAsync(userLoginDTO.UserName, userLoginDTO.Password, false, false);
            if (inResult.Succeeded)
            {
                var authUser = this._signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == userLoginDTO.UserName.ToUpper());
                var token = this._tokenService.TokenGenerator(authUser);
                return new DataTokenDTO(token);
            }

            throw new ApplicationException("User registration failed!");
        }
    }
}
