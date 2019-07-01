using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.Models.Requests;
using BTM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public bool IsInRole(string username, string roleName)
        {
            var exists = _context.UserRoles
                .Include(role => role.Role)
                .Include(user => user.User)
                .AsNoTracking()
                .Where(u => u.User.Username == username && u.Role.Name == roleName)
                .FirstOrDefault();

            if (exists != null)
                return true;
            else
                return false;
        }
		
		[HttpGet("GetRoles")]
        public IEnumerable<UserModificationModel> GetRoles(string username)
        {
            var exists = _context.Users
                .Include(role => role.Roles)
                .AsNoTracking()
                //.Where(x => x.Username.Contains(username))
                .ToList();

            if (username != "" && username != null)
            {
                exists = exists.Where(x => x.Username.Contains(username)).ToList();
            }

            if (exists == null)
            {
                return null;
            }

            var lst = new List<UserModificationModel>();
            foreach (var item in exists)
            {
                UserModificationModel model = new UserModificationModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Username = item.Username
                };
                if (IsInRole(item.Username, "Admin"))
                {
                    model.IsAdmin = true;
                }
                else
                {
                    model.IsAdmin = false;
                }

                lst.Add(model);
            }

            return lst;
        }

        [HttpPut("SetAdmin/{id}")]
        [Authorize(Roles = "Admin")]
        public void SetRole(int id, [FromBody] bool value)
        {
            var user = _context.UserRoles
                .Where(i => i.UserID == id && i.RoleID == 2)
                .FirstOrDefault();

            if (user == null) // Add
            {
                UsersRoles model = new UsersRoles
                {
                    UserID = id,
                    RoleID = 2
                };
                _context.UserRoles.Add(model);
                _context.SaveChanges();
                return;
            }
            else // Remove
            {
                _context.UserRoles.Remove(user);
                _context.SaveChanges();
                return;
            }
        }
    }
}