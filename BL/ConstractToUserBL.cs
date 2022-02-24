using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class ConstractToUserBL
    {
        public static void AddConstractToUser(ConstractToUserDTO c)
        {
            var constractToUs = ConstractToUserDTO.ToConstractToUser(c);
            ConstractToUserDAL.AddConsractToUser(constractToUs);
        }
        public static bool CheckIfConstractExist(ConstractToUserDTO c)
        {
            var constractToUs = ConstractToUserDTO.ToConstractToUser(c);
            return ConstractToUserDAL.CheckIfConstractExist(constractToUs);
        }
        public static double UpdateConstractToUser(ConstractToUserDTO c, double moneyToAdd)
        {
            var constractToUser = ConstractToUserDTO.ToConstractToUser(c);
           return ConstractToUserDAL.UpdateConstractToUser(constractToUser, moneyToAdd);
        }

    }
}
