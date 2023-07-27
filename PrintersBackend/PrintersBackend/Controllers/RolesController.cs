using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using PrintersBackend.Models;
using PrintersBackend.Options;
using Microsoft.EntityFrameworkCore;

namespace PrintersBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private readonly UserContext _context;
        public RolesController(UserContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Role Get(int id)
        {
            var role = _context.Roles.FirstOrDefault(x => x.Id == id);

            if (role == null)
                role = new Role();

            return role;
        }
    }
}
