using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConstractToUserDAL
    {
        public static void AddConsractToUser(ConstractToUser c)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                db.ConstractToUsers.Add(c);
                db.SaveChanges();
            }
        }
        public static bool CheckIfConstractExist(ConstractToUser c)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                var cc = db.ConstractToUsers.FirstOrDefault(x => x == c);
                if (cc == null)
                    return false;
                return true;
            }
        }
        public static double UpdateConstractToUser(ConstractToUser c, double moneyToAdd)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                var cc = db.ConstractToUsers.FirstOrDefault(x => x == c);
                if (cc != null)
                {
                    db.ConstractToUsers.Remove(cc);
                    cc.accumulatedAmount += moneyToAdd;
                    db.ConstractToUsers.Add(cc);
                    return cc.accumulatedAmount;
                }
                return -1;

            }
        }



    }
}

