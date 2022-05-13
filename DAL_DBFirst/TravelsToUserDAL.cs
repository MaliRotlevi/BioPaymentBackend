using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DBFirst;

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
            
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                List<TravelToUser> listResult = new List<TravelToUser>();
                List<TravelToUser> listData = db.TravelToUsers.ToList();

                for (int index = 0; index < listData.Count; index++)
                {
                    if (listData[index].userId == id)
                    {
                        listResult.Add(listData[index]);
                    }
                }
                return listResult;
            }
        }


    }
}
