using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BL
{
    public class UserBL
    {
        public string Auth(string n, string p)
        {

            return null;// new DAL_DBFirst.UserDAL ().AuthUser (n,p).id;
        }
        public static List<UserDTO> GetListUsers()
        {
            List<UserDTO> u = new List<UserDTO>();
            var list = UserDAL.AllUsers();
            var listDTO = UserDTO.ToUserDTOList(list).ToList();
            u.AddRange(listDTO);
            return u;
        }
        public static UserDTO GetUserByUserNameAndPassword(string userName,string password)
        {
            User u = UserDAL.GetUserByUserNameAndPassword(userName, password);
            var userDTO = UserDTO.ToUserDTO(u);
            return userDTO;
        }
        public static void AddUser(UserDTO u)
        {
            var user=UserDTO.ToUser(u);
            UserDAL.AddUser(user);
        }
        public static void RemoveUser(string id)
        {
            UserDAL.RemoveUser(id);
        }
        public static void UpdateProfile(int profileCode,string id)
        {
            UpdateProfile(profileCode,id);
        }
    }
}
