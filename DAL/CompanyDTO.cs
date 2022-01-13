using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CompanyDTO
    {
        public int companyCode;
        public string companyName;

        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static CompanyDTO ToCompanyDTO(Company c)
        {
            CompanyDTO cc = new CompanyDTO();
            cc.companyCode = c.companyCode;
            cc.companyName = c.companyName;
            return cc;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static Company ToCompany(CompanyDTO c)
        {
            Company cc = new Company();
            cc.companyCode = c.companyCode;
            cc.companyName = c.companyName;
            return cc;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<CompanyDTO> ToCompanyDTOList(List<Company> c)
        {
            List<CompanyDTO> cc = new List<CompanyDTO>();
            foreach (var item in c)
            {
                cc.Add(ToCompanyDTO(item));
            }
            return cc;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<Company> ToCompanyList(List<CompanyDTO> c)
        {
            List<Company> cc = new List<Company>();
            foreach (var item in c)
            {
                cc.Add(ToCompany(item));
            }
            return cc;
        }

    }
}