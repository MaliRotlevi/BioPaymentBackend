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
    [EnableCors(methods: "*", origins: "*", headers: "*")]
    [RoutePrefix("api/contracts")]
    public class ContractsController : ApiController
    {
        [Route("getAllContracts")]
        [HttpGet]

        public List<ContractTravelDTO> getAll()
        {
            return BL.ContractsBL.GetAllContracts();
        }
    }
}