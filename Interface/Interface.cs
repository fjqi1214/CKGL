using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Interface
{
    public interface IUserLogin
    {
         User GetUser(string name, string pwd);
    }

    public interface ISplitePageQuery<T>
    {
        IEnumerable<T> MoveNextPage(int pageNum, int size);
        IEnumerable<T> MovePreviousPage(int pageNum, int size);
        IEnumerable<T> MoveLastPage(int pageNum, int size);
        IEnumerable<T> MoveFirstPage(int pageNum, int size);
        long GetCount();
    }

    /// <summary>
    /// 用于保存 ISplitePageQuery<T> 相当于object
    /// </summary>
    public interface ISplitePage
    {

    }

}
