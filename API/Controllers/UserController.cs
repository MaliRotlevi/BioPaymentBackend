using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using BL;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(methods:"*",origins:"*",headers:"*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        
        [Route("getUser")]
        [HttpGet]
        public UserDTO GetUser(string userName,string password)
        {
            UserDTO u = UserBL.GetUserByUserNameAndPassword(userName, password);
            
            return u;
            
              
        }
        [Route("addUser")]
        [HttpPost]
        public IHttpActionResult AddUser([FromBody]UserDTO u)
        {
            if (UserBL.CheckIfUserExist(u.id))
                return Conflict();
            UserBL.AddUser(u);
            return Created("Added successfully", u);
        }
        //האם צריך להחזיר את העצם ואם זה created בכלל
        [Route ("updateUser")]
        [HttpPut]
        public IHttpActionResult UpdateUser([FromBody]UserDTO u)
        {
            if (!UserBL.UpdateUser(u))
                return Conflict();
            return Created("update successfully", u);
        }
    }
}