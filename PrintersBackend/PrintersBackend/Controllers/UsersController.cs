using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using PrintersBackend.Models;
using PrintersBackend.Serviceis;
using PrintersBackend.Options;

namespace PrintersBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            try
            {
                var users = _userService.GetUsers();
                return users;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public int Add(User user)
        {
            return _userService.AddUser(user);
        }

        [HttpGet("role/{name}")]
        public string getRole(string name)
        {
            return _userService.getRole(name);
        }

        [HttpDelete("{id}")]
        public int Remove(int id)
        {
            return _userService.RemoveUser(id);
        }

        [HttpPut]
        public void Update(User user)
        {
            _userService.UpdateUser(user);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("token")]
        public login_token Token(User user)
        {
            login_token response = new login_token();
            string username = user.Mail;
            string password = user.Password;
            var identity = _userService.GetIdentity(username, password);
            if (identity == null)
            {
                return response;
            }

            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            response.token = encodedJwt;
            response.name = identity.Name;

            return response;
        }
    }
}
