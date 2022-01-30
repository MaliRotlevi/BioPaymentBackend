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
        public int lineCode;


        public static BusDTO ToBusDTO(Bus b)
        {
            BusDTO bb = new BusDTO();
            bb.codeBus = b.codeBus;
            bb.lineCode = b.codeLine;
            return bb;
        }
        public static Bus ToBus(BusDTO b)
        {
            Bus bb = new Bus();
            bb.codeBus = b.codeBus;
            bb.codeLine = b.lineCode;
            return bb;
        }
        public static List<BusDTO> ToListBusDTO(List<Bus> b)
        {
            List<BusDTO> bb = new List<BusDTO>();
            foreach (var item in b)
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