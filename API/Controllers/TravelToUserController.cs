using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;
using DTO;

namespace API.Controllers
{
    [RoutePrefix ("api/travelsToUser")]
    public class TravelToUserController : ApiController
    {
        [Route ("getAllTravelsToUser")]
        [HttpGet]
        public List<TravelToUserDTO> GetTravelsToUser(string id)
        {
            return TravelToUserBL.GetAllTravelsToUser(id);
        }

    }
}