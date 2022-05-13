using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
     public class ContractsBL
    {
        public static List<ContractTravelDTO> GetAllContracts()
        {
            var t = DAL.ContractsDAL.GetAllContracts();
            return ContractTravelDTO.ToContractTravelDTOList(t);
        }
    }
}
