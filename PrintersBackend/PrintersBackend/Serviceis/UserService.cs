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

namespace PrintersBackend.Serviceis
{
    public class UserService
    {
        private readonly UserContext _context;
        private HashPass hashPass = new HashPass();
        public UserService(UserContext context)
        {
            _context = context;
        }
        public List<User> GetUsers()
        {
            return _context.Users
                .Include(x => x.role)
                .ToList();
        }
        public User GetUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
                user = new User();
            return user;
        }
        public int AddUser(User user)
        {
            user.Password = hashPass.getHash(user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
        public void UpdateUser(User user)
        {
            user.Password = hashPass.getHash(user.Password);
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public int RemoveUser(int id)
        {
            User user = GetUser(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return id;
            }
            else
            {
                return -1;
            }
        }
        public string getRole(string name)
        {
            return  _context.Users.Where(x => x.Mail == name)
                .Select(x => x.role.Name)
                .FirstOrDefault();
        }
        public ClaimsIdentity GetIdentity(string username, string password)
        {
            string hpassword = hashPass.getHash(password);
            var user = _context.Users.FirstOrDefault(x => x.Mail == username && x.Password == hpassword);
            if (user != null)
            {
                user.role = _context.Roles.FirstOrDefault(x => x.Id == user.RoleId);
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Mail),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.role.Name)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            return null;
        }
    }
}
