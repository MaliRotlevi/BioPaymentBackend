using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class ContractToUserBL
    {
        ////אם יש לו חוזה כלשהו
        ////public static bool IfExistAnyContract(string userId)
        ////{
        ////    return ContractToUserDAL.IfExistAnyContract(userId);
        ////}


        //הוספת חוזה לנוסע


        public static ContractToUserDTO AddContractToUser(ContractToUserDTO c)
        {
            var contractToUs = ContractToUserDTO.ToContractToUser(c);
            var cc =ContractToUserDTO.ToContractToUserDTO(ContractToUserDAL.AddConsractToUser(contractToUs));
            return cc;
        }
        //אם יש לנוסע כזה חוזה כבר
        public static bool CheckIfContractExist(ContractToUserDTO c)
        {
            var contractToUs = ContractToUserDTO.ToContractToUser(c);
            return ContractToUserDAL.CheckIfContractExist(contractToUs);
        }
        public static ContractToUserDTO UpdateContractToUser(ContractToUserDTO c, double moneyToAdd)
        {
            var contractToUser = ContractToUserDTO.ToContractToUser(c);
            var co= ContractToUserDAL.UpdateContractToUser(contractToUser, moneyToAdd);
            return ContractToUserDTO.ToContractToUserDTO(co);
        }
        public static List<ContractToUserDTO> GetAllContractsToUser(string id)
        {
            var t = ContractToUserDAL.GetContractToUsers(id);
            return ContractToUserDTO.ToListContractToUserDTO(t);
        }
        //אם יש לו כבר ערך צבור
        //public static bool IfExistStoredValue(string userId)
        //{
        //    return ContractToUserDAL.IfExistStoredValue(userId);
        //}

        public static ContractToUserDTO AddContractToUserNotAccumulated(ContractToUserDTO c)
        {
            var cc = ContractToUserDAL.AddContractNotAccumulated(ContractToUserDTO.ToContractToUser(c));
            if(cc!=null)
            return ContractToUserDTO.ToContractToUserDTO(cc);
            return null;

        }
    }
}
