using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DBFirst;

namespace DAL
{
   public class ContractsDAL
    {
        public static List<ContractTravel> GetAllContracts()
        {

            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                return db.ContractTravels.ToList();
            }
        }
    }
}
