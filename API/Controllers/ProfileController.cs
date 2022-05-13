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
    [EnableCors(methods: "*", origins: "*", headers: "*")]
    [RoutePrefix("api/profile")]
    public class ProfileController : ApiController
    {
        [Route("getProfileName")]
        [HttpGet]
        public ProfileDTO GetNameOfProfile(int num)
        {
            try
            {
                ProfileDTO p = ProfileBL.GetProfileName(num);
                if (p != null)
                {
                    return p;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        [Route("getAllProfiles")]
        [HttpGet]

        public List<ProfileDTO> getAll()
        {
            return BL.ProfileBL.GetAllProfiles();
        }
    }
}