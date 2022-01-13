using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class TravelToUserBL
    {
        public static void AddTravelToUser(TravelToUserDTO t)
        {
            var tt = TravelToUserDTO.ToTravelToUser(t);
            TravelsToUserDAL.AddTravelToUSer(tt);
        }
        public static void DeleteTravelToUser(string userId,TravelToUserDTO t)
        {
            var tt = TravelToUserDTO.ToTravelToUser(t);
            TravelsToUserDAL.DeleteTravelToUser(userId, tt);
        }
        

        
    }
}
