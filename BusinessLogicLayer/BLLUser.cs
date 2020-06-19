using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion;

namespace BusinessLogicLayer
{
    public class BLLUser
    {
        public static List<BEUser> Usuarios = new List<BEUser> {
            new BEUser { Username = "admin", Password = "admin1234", IdRol = (int)RolEnum.Admin, IdUser = 1 } ,
            new BEUser{ Username="user",Password="user1234",IdRol=(int)RolEnum.User,IdUser=2 } };

        public BEUser ValidateUser(string username, string password)
        {
            BEUser find = Usuarios.Where(a => a.Username.ToUpper().Equals(username.ToUpper()) && a.Password.Equals(password)).
                FirstOrDefault();

            return find;
        }
    }
}
