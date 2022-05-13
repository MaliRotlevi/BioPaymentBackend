using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DBFirst;

namespace DAL
{
    public class ContractToUserDAL
    {
        //הוספת חוזה לנוסע
        public static ContractToUser AddConsractToUser(ContractToUser c)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                db.ContractToUsers.Add(c);
                db.SaveChanges();
                return c;
            }
        }
        //אם יש לו כבר ערך צבור
        //public static bool IfExistStoredValue(string userId)
        //{
        //    using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
        //    {
        //        var u = db.ContractToUsers.FirstOrDefault(x => x.userId == userId && x.contractCode==1);
        //        if (u == null)
        //            return false;
        //        return true;
        //    }
        //}
        ////אם קיים לו חוזה אחר יומי/חודשי/שבועי
        //public static bool IfExistAnyContract(string userId)
        //{
        //    using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
        //    {
        //        var u = db.ContractToUsers.FirstOrDefault(x => x.userId == userId && x.contractCode != 1);
        //        if (u == null)
        //            return false;
        //        return true;
        //    }
        //}
        //אם קיים כזה חוזה 
        public static bool CheckIfContractExist(ContractToUser c)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                var cc = db.ContractToUsers.FirstOrDefault(x => x.userId == c.userId && x.contractCode==c.contractCode && x.isActive);
                if (cc == null)
                    return false;
                return true;
            }
        }
        //בדיקה איזה פרופיל יש לנוסע
        public static double CheckProfile(string id,double moneyToAdd)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                var p = db.Users.FirstOrDefault(x => x.id == id).profileCode;
                if (p == 2 || p == 4)
                    return moneyToAdd * 2;
                if (p == 1)
                    return moneyToAdd * 1.5;
                return moneyToAdd * 1.1;
            }

        }
        //עדכון חוזה ערך צבור לנוסע עם עוד כסף
        public static ContractToUser UpdateContractToUser(ContractToUser c, double moneyToAdd)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                var cc = db.ContractToUsers.FirstOrDefault(x => x.userId == c.userId && x.contractCode == c.contractCode);
                if (cc != null)
                {
                    moneyToAdd = CheckProfile(c.userId, moneyToAdd);
                    db.ContractToUsers.Remove(cc);
                    db.SaveChanges();
                    cc.accumulatedAmount += Math.Round(moneyToAdd,1);
                    db.ContractToUsers.Add(cc);
                    db.SaveChanges();
                    return cc;
                }
                return null;

            }
        }
        public static void UpdateIsActive(List<ContractToUser> conToUs)
        {
            foreach(var item in conToUs)

            {
                if (item.contractCode!=1 && (item.startDate > DateTime.Now || item.endDate?.Date < DateTime.Now.Date))
                {
                    item.isActive = false;
                    using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
                    {
                       var c=db.ContractToUsers.FirstOrDefault(x => x.userId == item.userId && x.contractCode == item.contractCode);
                        c.isActive = false;
                    }


                }
            }
            
        }
        //כל החוזים של נוסע
        public static List<ContractToUser> GetContractToUsers(string userID)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                List<ContractToUser> listResult = new List<ContractToUser>();
                List<ContractToUser> listData = db.ContractToUsers.ToList();
                //עדכון isActive לחוזים לנוסע
                 UpdateIsActive(listData);
                for (int index = 0; index < listData.Count; index++)
                {
                    if (listData[index].userId == userID && listData[index].isActive)
                    {
                        listResult.Add(listData[index]);
                    }
                }
                return listResult;
            }
        }
        public static ContractToUser AddContractNotAccumulated(ContractToUser c)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                if (c.contractCode == 2)
                {
                    c.startDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
                    c.endDate = DateTime.Now.AddMonths(1);
                    c.isActive = true;
                    db.ContractToUsers.Add(c);
                    db.SaveChanges();
                    return c;
                }
                var listContract = GetContractToUsers(c.userId);
               if(c.contractCode==4 )
                {
                    var another = listContract.FirstOrDefault(a => a.contractCode == 2 && a.isActive);
                    if(another==null)
                    {
                        c.startDate = DateTime.Now;
                        c.endDate = DateTime.Now.AddDays(7);
                        c.isActive = true;
                        db.ContractToUsers.Add(c);
                        db.SaveChanges();
                        return c;
                    }
                }
               if(c.contractCode==3)
                {
                    var another = listContract.FirstOrDefault(a => (a.contractCode == 2 || a.contractCode == 4) && a.isActive);
                    if(another==null)
                    {
                        c.startDate = DateTime.Now;
                        c.endDate = DateTime.Now;
                        c.isActive = true;
                        db.ContractToUsers.Add(c);
                        db.SaveChanges();
                        return c;
                    }
                }
                return null;
                
            }

        }



    }
}

