using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
		private readonly MyContext _context;

		public UserController(MyContext context){
            this._context = context;

        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            List<User> users = _context.Users.ToList();
            return Json(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
				_context.Users.Add(user);
                _context.SaveChanges();
            }
            return Json(user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
