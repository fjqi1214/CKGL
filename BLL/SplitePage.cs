using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
namespace BLL
{
    public class SplitePage<T> : ISplitePage
    {

        public SplitePage()
        {
            currentPageNum = 0;
            PageSize = 5;
        }

        /// <summary>
        /// 当前页 (页数从零开始)
        /// </summary>
        private int currentPageNum;

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }

        public int CurrentPageNum { get { return currentPageNum; } }

        public ISplitePageQuery<T> SplitePager { get; set; }



        public IEnumerable<T> MoveNextPage()
        {

            currentPageNum++;
            var items = SplitePager.MoveNextPage(currentPageNum, PageSize);
            var k = items.Count();
            //如果数量为0就到了数据库的结尾页号不增加
            if (k == 0)
            {
                currentPageNum--;
            }
            return items;

        }

        public IEnumerable<T> MovePreviousPage()
        {
            if (currentPageNum > 0)
                currentPageNum--;
            return SplitePager.MovePreviousPage(currentPageNum, PageSize);
        }

        public IEnumerable<T> MoveFirstPage()
        {
            currentPageNum = 0;
            return SplitePager.MoveLastPage(currentPageNum, PageSize);
        }

        public IEnumerable<T> MoveLastPage()
        {

            var total = SplitePager.GetCount();
            var i = (int)(total / PageSize);
            var k = total % PageSize;
            currentPageNum = k == 0 ? i - 1 : i;
            return SplitePager.MoveLastPage(currentPageNum, PageSize);
        }

       

    }
}
