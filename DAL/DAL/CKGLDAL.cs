using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
using Model;
namespace DAL
{
    public class CKGLDAL:IUserService
    {

        #region IUser Members

        public User GetUser(string name, string pwd)
        {
            return new User { Auth = AuthLevel.privilege, UserName = "admin" };
        }

        #endregion
    }
}
