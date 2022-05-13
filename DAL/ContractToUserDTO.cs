using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

//    accumulatedAmount: 10
//contractCode: 2
//endDate: "05/03/2022"
//startDate: "01/01/1900"
//userId: "324078468 "
    public class ContractToUserDTO
    {
        public int contractCode;
        public string userId;
        public double accumulatedAmount;
        public DateTime startDate;
        public DateTime endDate;
        public bool isActive;
        public static ContractToUserDTO ToContractToUserDTO(ContractToUser c)
        {
            ContractToUserDTO cc = new ContractToUserDTO();
            cc.contractCode = c.contractCode;
            cc.userId = c.userId;
            cc.accumulatedAmount = c.accumulatedAmount;
            cc.startDate = (DateTime)c.startDate;
            cc.endDate = (DateTime)c.endDate;
            cc.isActive = c.isActive;
            return cc;
        }
        public static ContractToUser ToContractToUser(ContractToUserDTO c)
        {
            ContractToUser cc = new ContractToUser();
            cc.contractCode = c.contractCode;
            cc.userId = c.userId;
            cc.accumulatedAmount = c.accumulatedAmount;
            cc.startDate = c.startDate;
            cc.endDate = c.endDate;
            cc.isActive = c.isActive;
            return cc;
        }

        public static List<ContractToUserDTO> ToListContractToUserDTO(List<ContractToUser> c)
        {
            List<ContractToUserDTO> cc = new List<ContractToUserDTO>();
            foreach(var item in c)
            {
                cc.Add(ToContractToUserDTO(item));
            }
            return cc;
        }
        public static List<ContractToUser> ToListContractToUser(List<ContractToUserDTO> c)
        {
            List<ContractToUser> cc = new List<ContractToUser>();
            foreach (var item in c)
            {
                cc.Add(ToContractToUser(item));
            }
            return cc;
        }
    }
}
