using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ConstractTravelDTO
    {
        public int contractCode;
        public string contractName;

        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static ConstractTravelDTO ToConstractTravelDTO(ConstractTravel c)
        {
            ConstractTravelDTO cc = new ConstractTravelDTO();
            cc.contractCode = c.contractCode;
            cc.contractName = c.contractName;
            return cc;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static ConstractTravel ToConstractTravel(ConstractTravelDTO c)
        {
            ConstractTravel cc = new ConstractTravel();
            cc.contractCode = c.contractCode;
            cc.contractName = c.contractName;
            return cc;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<ConstractTravelDTO> ToConstractTravelDTOList(List<ConstractTravel> c)
        {
            List<ConstractTravelDTO> cc = new List<ConstractTravelDTO>();
            foreach (var item in c)
            {
                cc.Add(ToConstractTravelDTO(item));
            }
            return cc;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<ConstractTravel> ToConstractTravelList(List<ConstractTravelDTO> c)
        {
            List<ConstractTravel> cc = new List<ConstractTravel>();
            foreach (var item in c)
            {
                cc.Add(ToConstractTravel(item));
            }
            return cc;
        }

    }
}




