using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class TravelsToUserDAL
    {
        public static void AddTravelToUSer(TravelToUser t)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                db.TravelToUsers.Add(t);
                db.SaveChanges();
            }
        }
        public static void DeleteTravelToUser(string userID,TravelToUser t)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                if(db.Users.FirstOrDefault(x=>x.id==userID).isDriver==true)
                {
                    db.TravelToUsers.Remove(t);
                    db.SaveChanges();
                }
            }

        }
        //פעולה מוזרהה
        public static List<TravelToUser> GetTravelsToUser(string id)
        {
            var t = new List<TravelToUser>();
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                t = (List<TravelToUser>)db.TravelToUsers.ToList().Where(x => x.userId == id);
                return t;
            }
        }


    }
}
