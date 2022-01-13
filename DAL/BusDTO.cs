using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BusDTO
    {
        public int codeBus;
        public string busLine;
        public double price;
        public int companyCode;

        public static BusDTO ToBusDTO(Bus b)
        {
            BusDTO bb = new BusDTO();
            bb.codeBus = b.codeBus;
            bb.busLine = b.busLine;
            bb.price = (int)b.price;
            bb.companyCode = (int)b.companyCode;
            return bb;
        }
        public static Bus ToBus(BusDTO b)
        {
            Bus bb = new Bus();
            bb.codeBus = b.codeBus;
            bb.busLine = b.busLine;
            bb.price = b.price;
            bb.companyCode = b.companyCode;
            return bb;
        }
        public static List<BusDTO> ToListBusDTO(List<Bus> b)
        {
            List<BusDTO> bb =new List<BusDTO>();
            foreach(var item in b)
            {
                bb.Add(ToBusDTO(item));
            }
            return bb;
        }
        public static List<Bus> ToListBus(List<BusDTO> b)
        {
            List<Bus> bb = new List<Bus>();
            foreach (var item in b)
            {
                bb.Add(ToBus(item));
            }
            return bb;
        }


    }
}
