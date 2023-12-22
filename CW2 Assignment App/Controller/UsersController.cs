using CW2_Assignment_App.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CW2_Assignment_App.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login(Login login)
        {
            try
            {
                if (string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Password))
                    return BadRequest("Email and/or Password not specified");

                // Send a POST request to validate user credentials through the external API
                var apiUrl = "https://web.socem.plymouth.ac.uk/COMP2001/auth/api/users";

                var client = _httpClientFactory.CreateClient();

                var response = await client.PostAsJsonAsync(apiUrl, new { Email = login.Email, Password = login.Password });

                if (response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();

                    // User validated - generate a JWT token based on the validated user data
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("thisisasecretkey@123"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var jwtSecurityToken = new JwtSecurityToken(
                        issuer: "Danny",
                        audience: "http://localhost:51398",
                        claims: new[] { new Claim(ClaimTypes.Name, login.Email) },
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signinCredentials
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                    return Ok(tokenString);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch
            {
                return BadRequest("An error occurred in generating the token");
            }
        }
    }
}