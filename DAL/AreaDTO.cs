using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class AreaDTO
    {
        public int areaCode;
        public string areaName;

        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static AreaDTO ToAreaDTO(Area a)
        {
            AreaDTO aa = new AreaDTO();
            aa.areaCode = a.areaCode;
            aa.areaName = a.areaName;
            return aa;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static Area ToArea(AreaDTO a)
        {
            Area aa = new Area();
            aa.areaCode = a.areaCode;
            aa.areaName = a.areaName;
            return aa;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<AreaDTO> ToAreaDTOList(List<Area> a)
        {
            List<AreaDTO> aa = new List<AreaDTO>();
            foreach (var item in a)
            {
                aa.Add(ToAreaDTO(item));
            }
            return aa;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<Area> ToAreaList(List<AreaDTO> a)
        {
            List<Area> aa = new List<Area>();
            foreach (var item in a)
            {
                aa.Add(ToArea(item));
            }
            return aa;
        }

    }
}