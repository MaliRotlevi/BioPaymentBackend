using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
      public class UserDTO
     {
        public string id;
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public string userName;
        public string password;
        public string fingerPrint;
        public int profileCode;
        public bool isDriver;
        //פעולה שמקבלת עצם ממחלקה של מיקרוסופט וממירה אותו לעצם מטיפוס המחלקה שלנו
        public static UserDTO ToUserDTO(User u)
        {
            UserDTO uu = new UserDTO();
            uu.id = u.id;
            uu.firstName = u.firstName;
            uu.lastName = u.lastName;
            uu.birthDate = (DateTime)u.birthDate;
            uu.userName = u.userName;
            uu.password = u.password;
            //uu.fingerPrint = u.fingerPrint;
            uu.profileCode = (int)u.profileCode;
            uu.isDriver = (bool)u.isDriver;
            return uu;
        }
        //פעולה שממירה אוביקט מהמחלקה שלנו למחלקה של מייקרוסופט
        public static User ToUser(UserDTO u)
        {
            User uu = new User();
            uu.id = u.id;
            uu.firstName = u.firstName;
            uu.lastName = u.lastName;
            uu.birthDate = u.birthDate;
            uu.userName = u.userName;
            uu.password = u.password;
            //uu.fingerPrint = u.fingerPrint;
            uu.profileCode = u.profileCode;
            uu.isDriver = u.isDriver;
            return uu;
        }
        //פעולה שממירה אוסף של מייקרוסופט לאוסף שלנו
        public static List<UserDTO> ToUserDTOList(List<User> u)
        {
            List<UserDTO> uu = new List<UserDTO>();
            foreach(var item in u)
            {
                uu.Add(ToUserDTO(item));
            }
            return uu;
        }
        //ממירה אוסף שלנו לאוף של מייקרוסופט
        public static List<User> ToUserList(List<UserDTO> u)
        {
            List<User> uu = new List<User>();
            foreach (var item in u)
            {
                uu.Add(ToUser(item));
            }
            return uu;
        }

    }
}
