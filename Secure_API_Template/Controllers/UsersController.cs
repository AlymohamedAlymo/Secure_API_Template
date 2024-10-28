using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Secure_API_Template.DataBase.Context;
using Secure_API_Template.DataBase.Entites;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Secure_API_Template.Controllers
{
    public class UsersController(DataContext dataContext) : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers()
        {
            return Ok(await dataContext.Users.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUsers>> GetUser(int id)
        {
            var user = await dataContext.Users.FindAsync(id);
            return user == null ? NotFound() : Ok(user);
        }


        [HttpPost("addNewUser")]
        public async Task<ActionResult<int>> AddNewUser(string UserName, string PassWord)
        {
            using var HashPass = new HMACSHA512();
            var user = new AppUsers
            {
                UserName = UserName,
                PasswordHash = HashPass.ComputeHash(Encoding.UTF8.GetBytes(PassWord)),
                PasswordSalt = HashPass.Key
            };
            dataContext.Users.Add(user);
            int Result = await dataContext.SaveChangesAsync();
            return Ok(Result);
        }

    }
}
