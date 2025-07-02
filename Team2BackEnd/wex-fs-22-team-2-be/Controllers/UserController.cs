using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Context _context;

        public UserController(Context context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.User;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == id);
            if (user != null)
                return Ok(user);
            return NotFound("A User wasn't found.");
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User user, bool isadmin)
        {
            user.Id = null;
            if (isadmin == true)
            {
                _context.User.Add(user);
                _context.SaveChanges();
                return Ok(user);
            }
            else
            {
                user.IsAdmin = false;
                user.IsShopKeeper = false;
                user.IsLoggedIn = true;
                _context.User.Add(user);                
                _context.SaveChanges();
                return Ok(user);
            }
        }

        [HttpPatch("Login/{username}/{password}")]
        public ActionResult Login(string username, string password)
        {
            var grabbedUser = _context.User.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (grabbedUser != null)
            {
                grabbedUser.IsLoggedIn = true;
                _context.SaveChanges();
                return Ok(grabbedUser);
            }
            return BadRequest();
        }

        [HttpPatch("Logout/{id}")]
        [Produces("application/json")]
        public ActionResult Login(int id)
        {
            var grabbedUser = _context.User.FirstOrDefault(x => x.Id == id);
            if (grabbedUser != null)
            {
                grabbedUser.IsLoggedIn = false;
                _context.SaveChanges();
                return Ok("logout worked");
            }
            return BadRequest("logout failed");
        }


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        /*public ActionResult Put(int id, [FromBody] User user, bool isadmin)*/
        public ActionResult Put([FromBody] UserCreateDataTransport userobj)
        {
            var userEdit = _context.User.FirstOrDefault(x => x.Id == userobj.userToCreate.Id);
           if(userobj.isAdmin == true && userobj.localuserid == userobj.userToCreate.Id)
            {
            userEdit.IsAdmin = true;
            userEdit.IsShopKeeper = false;
            userEdit.IsCustomer = false;
            userEdit.Username = userobj.userToCreate.Username;
            userEdit.Password = userobj.userToCreate.Password;
            userEdit.Email = userobj.userToCreate.Email;
            }
           else if(userobj.isAdmin == true)
            {
                userEdit.IsAdmin = userobj.userToCreate.IsAdmin;
                userEdit.IsShopKeeper = userobj.userToCreate.IsShopKeeper;
                userEdit.IsCustomer = userobj.userToCreate.IsCustomer;
                userEdit.Username = userobj.userToCreate.Username;
                userEdit.Password = userobj.userToCreate.Password;
                userEdit.Email = userobj.userToCreate.Email;
            }
            else
            {
                userEdit.IsAdmin = false;
                userEdit.IsShopKeeper = false;
                userEdit.IsCustomer = true;
                userEdit.Username = userobj.userToCreate.Username;
                userEdit.Password = userobj.userToCreate.Password;
                userEdit.Email = userobj.userToCreate.Email;
            }

            _context.User.Update(userEdit);
            _context.SaveChanges();
            return Ok(userEdit);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        [Produces("application/json")]

        //public ActionResult Delete(int id, [FromBody] int adminid)
        //{
        //    var user = _context.User.FirstOrDefault(x => x.Id == id);
        //    if (user.IsAdmin == true && user.Id == adminid)
        //        return BadRequest("You are unable to delete your own account.");
        //    else if (user.IsShopKeeper == true && user.IsAdmin == false)
        //        return BadRequest("How did you even get to this page?");
        //    _context.Remove(user);
        //    _context.SaveChanges();
        //    return Ok("User has been deleted");
        //}

        public ActionResult Delete(int id)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == id);
            _context.Remove(user);
            _context.SaveChanges();
            return Ok("User has been deleted");
        }
    }
}