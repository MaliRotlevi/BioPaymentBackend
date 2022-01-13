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
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                db.TravelToUsers.Add(t);
                db.SaveChanges();
            }
        }
        public static void DeleteTravelToUser(string userID,TravelToUser t)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                if(db.Users.FirstOrDefault(x=>x.id==userID).isDriver==true)
                {
                    db.TravelToUsers.Remove(t);
                    db.SaveChanges();
                }
            }

        }


    }
}
