using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class BusDAL
    {
        public static void AddBus(Bus b)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                db.Buses.Add(b);
                db.SaveChanges();
            }
        }
    }
}
