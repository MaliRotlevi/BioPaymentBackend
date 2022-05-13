using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DBFirst;

namespace DAL
{
    public class ProfileDAL
    {
        public static Profile GetProfileName(int num)
        {
            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                try
                {
                    var p = db.Profiles.FirstOrDefault(x => x.profileCode == num);
                    return p;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<Profile> GetAllProfiles()
        {

            using (FINGERPRINTINBUSDBEntities db = new FINGERPRINTINBUSDBEntities())
            {
                return db.Profiles.ToList();
            }
        }
    }
}
