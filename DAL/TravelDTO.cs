using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TravelDTO
    {
        
            public int travelCode;
            public int busCode;
            public DateTime date;
            public string driverId;

            //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
            public static TravelDTO ToTravelDTO(Travel t)
            {
                TravelDTO tt = new TravelDTO();
                tt.travelCode = t.travelCode;
                tt.busCode = (int)t.busCode;
                tt.date = (DateTime)t.date;
                tt.driverId = t.driverId;
                return tt;
            }
            //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
            public static Travel ToTravel(TravelDTO t)
            {
                Travel tt = new Travel();
                tt.travelCode = t.travelCode;
                tt.busCode = t.busCode;
                tt.date = t.date;
                tt.driverId = t.driverId;
                return tt;
            }
            //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
            public static List<TravelDTO> ToTravelsDTOList(List<Travel> t)
            {
                List<TravelDTO> tt = new List<TravelDTO>();
                foreach (var item in t)
                {
                    tt.Add(ToTravelDTO(item));
                }
                return tt;
            }
            //ממירה אוסף שלנו לאוף של מייקרוסופט
            public static List<Travel> ToTravelsList(List<TravelDTO> t)
            {
                List<Travel> tt = new List<Travel>();
                foreach (var item in t)
                {
                    tt.Add(ToTravel(item));
                }
                return tt;
            }

        
    }
}

