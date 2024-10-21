using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Secure_API_Template.DataBase.Context;
using Secure_API_Template.DataBase.Entites;

namespace Secure_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext dataContext) : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<AppUsers>> GetUsers()
        {
            return Ok(dataContext.Users.ToList());
        }


        [HttpGet("{id:int}")]
        public ActionResult<AppUsers> GetUser(int id)
        {
            var user = dataContext.Users.Find(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

    }
}
