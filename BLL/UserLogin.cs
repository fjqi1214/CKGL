using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
using Model;

namespace BLL
{
    public class UserLogin
    {
        public IUserService UserValidate { get; set; }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns>成功返回对象 否则返回null</returns>
        public User Login(string name, string pwd)
        {
            return UserValidate.GetUser(name, pwd);
        }
    }
}
