using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class TravelsBL
    {
        public static List<TravelDTO> GetAllTravels()
        {
            var t = DAL.TravelsDAL.GetAllTravles();
            return TravelDTO.ToTravelsDTOList(t);
        }
    }
}
