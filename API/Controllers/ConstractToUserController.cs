using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using DTO;
using BL;

namespace API.Controllers
{
    [RoutePrefix ("api/constractToUser")]
    [EnableCors(methods: "*", origins: "*", headers: "*")]
    public class ConstractToUserController : ApiController
    {
        [Route ("addConstractToUser")]
        [HttpPost]
        // GET: ConstractToUser
        public IHttpActionResult AddConstractToUser(ConstractToUserDTO c)
        {
            if (ConstractToUserBL.CheckIfConstractExist(c))
                return Conflict();
            ConstractToUserBL.AddConstractToUser(c);
            return Created("Added successfully", c);
        }
        [Route("updateConstractToUser")]
        [HttpPut]
        public IHttpActionResult UpdateConstractToUser(ConstractToUserDTO c,double moneyToAdd)
        {
            ConstractToUserBL.UpdateConstractToUser(c, moneyToAdd);
            return Created("updated successfully", c);
        }
        
    }
}