using BTM.Database;
using BTM.Models;
using BTM.Models.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTM.WebAPI.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> Get();
        List<User> Get(UserSearchModel request);
        User Get(int id);
        User Get(Expression<Func<User, bool>> predicate);
        IQueryable<User> GetByCondition(Expression<Func<User, bool>> predicate);
        User Register(UserRegistrationModel model);
    }

    public class UserService : IUserService
    {
        private ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public User Authenticate(string username, string password)
        {
            var user = _context.Users.Include("Roles.Role").FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash)
                {
                    return user;
                }
            }
            return null;
        }


        public IEnumerable<User> Get()
        {
            return _context.Users.AsEnumerable();
        }

        public List<User> Get(UserSearchModel request)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.FirstName))
            {
                query = query.Where(x => x.FirstName.StartsWith(request.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(request?.LastName))
            {
                query = query.Where(x => x.LastName.StartsWith(request.LastName));
            }

            if (request?.LoadRoles == true)
            {
                query = query.Include(x => x.Roles);
            }

            var list = query.ToList();

            return list;
        }

        public User Get(int id)
        {
            var entity = _context.Users.Find(id);

            return entity;
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate).FirstOrDefault();
        }

        public IQueryable<User> GetByCondition(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate);
        }

        public User Register(UserRegistrationModel model)
        {
            // Might remove
            var usernameExists = _context.Users.Where(x => x.Username == model.Username).FirstOrDefault();
            var emailExists = _context.Users.Where(x => x.Email == model.Email).FirstOrDefault();
            if (usernameExists != null || emailExists != null)
            {
                throw new Exception("Email or username already exist in the database");
            }


            if (model.Password != model.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var user = new User
            {
                Email = model.Email,
                Username = model.Username,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                JoinDate = DateTime.Now,
                Avatar = model.Avatar,
                DateOfBirth = model.DateOfBirth,
                FBLink = model.FBLink,
                InstagramLink = model.InstagramLink,
                LinkedInLink = model.LinkedInLink,
                TwitterLink = model.TwitterLink
            };

            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(user.PasswordSalt, model.Password);

            _context.Users.Add(user);
            _context.SaveChanges();

            foreach (var item in model.Roles)
            {
                UsersRoles usersRoles = new UsersRoles
                {
                    UserID = user.Id,
                    RoleID = item
                };
                _context.UserRoles.Add(usersRoles);
            }
            _context.SaveChanges();

            return user;
        }

        //Not tested
        public User Update(User obj)
        {
            _context.Attach(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        //Not tested
        public User Update(int id, User entity)
        {
            var model = _context.Users.Find(id);

            model.Username = entity.Username;
            model.PasswordHash = entity.PasswordHash;
            model.Email = entity.Email;
            model.Avatar = entity.Avatar;

            model.FirstName = entity.FirstName;
            model.MiddleName = entity.MiddleName;
            model.LastName = entity.LastName;
            model.DateOfBirth = entity.DateOfBirth;

            model.FBLink = entity.FBLink;
            model.InstagramLink = entity.InstagramLink;
            model.LinkedInLink = entity.LinkedInLink;
            model.TwitterLink = entity.TwitterLink;


            _context.Users.Attach(model);
            _context.SaveChanges();
            return model;
        }

        /*public User Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }*/







        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
