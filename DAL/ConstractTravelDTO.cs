using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContractTravelDTO
    {
        public int contractCode;
        public string contractName;
        public double price;

        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static ContractTravelDTO ToContractTravelDTO(ContractTravel c)
        {
            ContractTravelDTO cc = new ContractTravelDTO();
            cc.contractCode = c.contractCode;
            cc.contractName = c.contractName;
            cc.price = (double)c.price;
            return cc;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static ContractTravel ToContractTravel(ContractTravelDTO c)
        {
            ContractTravel cc = new ContractTravel();
            cc.contractCode = c.contractCode;
            cc.contractName = c.contractName;
            cc.price = c.price;
            return cc;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<ContractTravelDTO> ToContractTravelDTOList(List<ContractTravel> c)
        {
            List<ContractTravelDTO> cc = new List<ContractTravelDTO>();
            foreach (var item in c)
            {
                cc.Add(ToContractTravelDTO(item));
            }
            return cc;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<ContractTravel> ToContractTravelList(List<ContractTravelDTO> c)
        {
            List<ContractTravel> cc = new List<ContractTravel>();
            foreach (var item in c)
            {
                cc.Add(ToContractTravel(item));
            }
            return cc;
        }

    }
}




