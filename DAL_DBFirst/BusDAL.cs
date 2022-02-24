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
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                db.Buses.Add(b);
                db.SaveChanges();
            }
        }
    }
}
