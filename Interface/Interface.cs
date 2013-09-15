using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Interface
{
    public interface IUserService
    {
         User GetUser(string name, string pwd);
    }
}
