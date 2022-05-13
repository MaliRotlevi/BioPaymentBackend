using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TravelsDAL
    {
        public static List<Travel> GetAllTravles()
        {

            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                return db.Travels.ToList();
            }
        }
    }
}
