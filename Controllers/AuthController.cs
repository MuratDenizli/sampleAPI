using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sampleAPI.Data;
using sampleAPI.Dtos.User;
using sampleAPI.Models;

namespace sampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Regsiter(
                new User { Username = request.Username }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request){
            ServiceResponse<string> response = await _authRepo.Login(request.Username, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}