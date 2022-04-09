using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Entities;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly StudentDbContext _studentDbContext;
        private readonly IConfiguration _configuration;

        public AuthController(StudentDbContext studentDbContext, IConfiguration configuration)
        {
            _studentDbContext = studentDbContext;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult<LoginResultModel>> Login(LoginDto loginDto)
        {
            var user = await _studentDbContext.Users.FirstOrDefaultAsync(x => x.Email == loginDto.Email && x.Password == loginDto.Password);

            if (user == null)
            {
                return NotFound(new
                {
                    Message = "Username or password is not correct. Please check again!"
                });
            }

            var token = GenerateJwtToken(user);

            return Ok(new LoginResultModel
            {
                UserId = user.Id,
                ResulToken = token
            });
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FullName.Split().First().ToString()),
                new Claim(ClaimTypes.Name, user.FullName.Split().Last().ToString())
            };

            if (user.Role.Length > 0)
            {
                claims.Add(new Claim(ClaimTypes.Role, string.Join(",", user.Role)));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = System.DateTime.UtcNow.AddHours(0.5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
