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
    [RoutePrefix("api/contractToUser")]
    public class ContractToUserController : ApiController
    {
        [Route("addContractToUser")]
        [HttpPost]
        public IHttpActionResult AddContractToUser([FromBody] ContractToUserDTO c, double moneyToAdd)
        {
            //אם יש לו כבר אותו חוזה בדיוק
            if (ContractToUserBL.CheckIfContractExist(c))
            {
                if (c.contractCode == 1)
                {
                    var cc1 = ContractToUserBL.UpdateContractToUser(c, moneyToAdd);


                    return Created("Added money to your accumulated",cc1);
                }
                else
                    return Conflict();
            }
            //אם אין לו אותו חוזה בדיוק
            if (c.contractCode == 1)
            {
                c.isActive = true;
                var cc = ContractToUserBL.AddContractToUser(c);
                return Created("Added successfully", cc);
            }
            
            var cc2 = ContractToUserBL.AddContractToUserNotAccumulated(c);
            if(cc2!=null)
                return Created("Added successfully", cc2);
            return Conflict();

        }


        [Route("updateContractToUser")]
        [HttpPut]
        public IHttpActionResult UpdateContractToUser(ContractToUserDTO c, double moneyToAdd)
        {
            var cc = ContractToUserBL.UpdateContractToUser(c, moneyToAdd);
            return Created("updated successfully", cc);
        }
        [Route("getContractsToUser")]
        [HttpGet]
        public List<ContractToUserDTO> GetContractsToUser(string userId)
        {
            return BL.ContractToUserBL.GetAllContractsToUser(userId);
        }
        //[Route("ifExistStoredValue")]
        //[HttpGet]
        //public static bool IfExistStoredValue(string userId)
        //{
        //    return BL.ContractToUserBL.IfExistStoredValue(userId);
        //}
        //[Route("ifExistAnyContract")]
        //[HttpGet]
        //public static bool IfExistAnyContract(string userId)
        //{
        //    return ContractToUserBL.IfExistAnyContract(userId);
        //}


    }
}