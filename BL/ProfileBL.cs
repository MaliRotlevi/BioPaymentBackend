using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;



namespace BL
{
    public class ProfileBL
    {
        public static ProfileDTO GetProfileName(int num)
        {
            var p= ProfileDAL.GetProfileName(num);
            return ProfileDTO.ToProfileDTO(p);
        }
        public static List<ProfileDTO> GetAllProfiles()
        {
            var p = DAL.ProfileDAL.GetAllProfiles();
            return ProfileDTO.ToProfilesDTOList(p);
        }
    }
}
