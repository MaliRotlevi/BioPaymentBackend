using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TravelToUserDTO
    {
        public string userId;
        public int travelCode;
        public DateTime date;
        public TimeSpan hour;
        public int boardingStation;
        public int dropStation;

        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static TravelToUserDTO ToTravelToUserDTO(TravelToUser t)
        {
            TravelToUserDTO tt = new TravelToUserDTO();
            tt.userId = t.userId;
            tt.travelCode = t.travelCode;
            tt.date = t.date;
            tt.hour = t.hour;
            tt.boardingStation = t.boardingStation;
            tt.dropStation = t.dropStation;
            return tt;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static TravelToUser ToTravelToUser(TravelToUserDTO t)
        {
            TravelToUser tt = new TravelToUser();
            tt.userId = t.userId;
            tt.travelCode = t.travelCode;
            tt.date = t.date;
            tt.hour = t.hour;
            tt.boardingStation = t.boardingStation;
            tt.dropStation = t.dropStation;
            return tt;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<TravelToUserDTO> ToListOfTravelToUserDTO(List<TravelToUser> t)
        {
            List<TravelToUserDTO> tt = new List<TravelToUserDTO>();
            foreach (var item in t)
            {
                tt.Add(ToTravelToUserDTO(item));
            }
            return tt;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<TravelToUser> ToListOfTravelToUser(List<TravelToUserDTO> t)
        {
            List<TravelToUser> tt = new List<TravelToUser>();
            foreach (var item in t)
            {
                tt.Add(ToTravelToUser(item));
            }
            return tt;
        }
    }
}
