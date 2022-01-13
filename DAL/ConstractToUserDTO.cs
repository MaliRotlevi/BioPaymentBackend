using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ConstractToUserDTO
    {
        public int constractCode;
        public string userId;
        public double accumulatedAmount;

        public static ConstractToUserDTO ToConstractToUserDTO(ConstractToUser c)
        {
            ConstractToUserDTO cc = new ConstractToUserDTO();
            cc.constractCode = c.constractCode;
            cc.userId = c.userId;
            cc.accumulatedAmount = c.accumulatedAmount;
            cc.accumulatedAmount = c.accumulatedAmount;
            return cc;
        }
        public static ConstractToUser ToConstractToUser(ConstractToUserDTO c)
        {
            ConstractToUser cc = new ConstractToUser();
            cc.constractCode = c.constractCode;
            cc.userId = c.userId;
            cc.accumulatedAmount = c.accumulatedAmount;
            cc.accumulatedAmount = c.accumulatedAmount;
            return cc;
        }

        public static List<ConstractToUserDTO> ToListConstractToUserDTO(List<ConstractToUser> c)
        {
            List<ConstractToUserDTO> cc = new List<ConstractToUserDTO>();
            foreach(var item in c)
            {
                cc.Add(ToConstractToUserDTO(item));
            }
            return cc;
        }
        public static List<ConstractToUser> ToListConstractToUser(List<ConstractToUserDTO> c)
        {
            List<ConstractToUser> cc = new List<ConstractToUser>();
            foreach (var item in c)
            {
                cc.Add(ToConstractToUser(item));
            }
            return cc;
        }
    }
}
