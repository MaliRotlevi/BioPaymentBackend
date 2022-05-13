using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProfileDTO
    {

       
            public int profileCode;
            public string profileName;

            //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
            public static ProfileDTO ToProfileDTO(Profile p)
            {
                ProfileDTO pr = new ProfileDTO();
                pr.profileCode = p.profileCode;
                pr.profileName = p.profileName;
                return pr;
            }
            //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
            public static Profile ToProfile(ProfileDTO p)
            {
                Profile pr = new Profile();
                pr.profileCode = p.profileCode;
                pr.profileName = p.profileName;
                return pr;
            }
            //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
            public static List<ProfileDTO> ToProfilesDTOList(List<Profile> p)
            {
                List<ProfileDTO> pr = new List<ProfileDTO>();
                foreach (var item in p)
                {
                    pr.Add(ToProfileDTO(item));
                }
                return pr;
            }
            //ממירה אוסף שלנו לאוף של מייקרוסופט
            public static List<Profile> ToProfilesList(List<ProfileDTO> p)
            {
                List<Profile> pr = new List<Profile>();
                foreach (var item in p)
                {
                    pr.Add(ToProfile(item));
                }
                return pr;
            }

        }
    }
