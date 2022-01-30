using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public User AuthUser(string name, string pass)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                User u = (db.Users .SingleOrDefault(a => a.userName == name && a.password == pass));
                    return u;
                    }
        }
        public static List<User> AllUsers()
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                List<User> u = db.Users.ToList();
                return u;
            }
        }
        public static Boolean GetUserById(string id)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                User u = db.Users.FirstOrDefault(x => x.id == id);
                return u != null;
            }

        }
        public static User GetUserByUserNameAndPassword(string userName,string password)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                User u = db.Users.FirstOrDefault(x => x.userName == userName && x.password == password);
               
                return u;
            }
        }
        public static void AddUser(User u)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
        }
        public static void RemoveUser(string id)
        {
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                User u = db.Users.FirstOrDefault(x => x.id == id);
                db.Users.Remove(u);
                db.SaveChanges();
            }
        }
        
        //public static void UpdateProfile(int codeProfile,User u)
        //{
        //    using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
        //    {
        //        //int age=(int)(DateTime.Today.Year)-u.birthDate.Year
        //        //if(codeProfile==0 &&  u.birthDate)
        //        //db.Users.FirstOrDefault(x => x.id == u.id).profileCode = codeProfile;
        //        //db.SaveChanges();

        //    }
        //}
        public static bool UpdateUser(User u)
        {
            if (u == null)
                return false;
            using (fingerPrintInBusDBEntities db = new fingerPrintInBusDBEntities())
            {
                User uu = db.Users.FirstOrDefault(x => x.id == u.id);
                if (uu == null)
                    return false;
                db.Users.Remove(u);
                db.Users.Add(uu);
                db.SaveChanges();
                return true;
            }
        }
    }
}
