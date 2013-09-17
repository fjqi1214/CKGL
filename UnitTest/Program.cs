using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using Model;
using DAL;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitePage<StorageLocation> pager = new SplitePage<StorageLocation>();
            pager.SplitePager = new StorageLocationCollection();



            TestGoFirst(pager);

            PrintSplitLine();

            TestGoNexPage(pager);

            PrintSplitLine();

            TestRemainderItems(pager);
          

            PrintSplitLine();

            TestGoToFirstPage(pager);

            PrintSplitLine();

            TestGoLastPage(pager);
            PrintSplitLine();

        

            Console.ReadKey();

        }

        /// <summary>
        /// 测试返回第一页
        /// </summary>
        /// <param name="pager"></param>
        static private void TestGoFirst(SplitePage<StorageLocation> pager)
        {
            var items = pager.MoveFirstPage();
            if (FirstPageIsOk(items, pager.PageSize))
            {
                Console.WriteLine("回到第一页-------正确！");
                if (pager.CurrentPageNum == 0)
                {
                    Console.WriteLine("当前页码为0------正确！");
                }
                else
                {
                    Console.WriteLine("当前页码为0------失败！");
                }
            }
            else
            {
                Console.WriteLine("回到第一页------失败！");
            }
        
        }

        /// <summary>
        /// 测试进入第一页
        /// </summary>
        /// <param name="pager"></param>
        static private void TestGoNexPage(SplitePage<StorageLocation> pager)
        {
            var currentPage = pager.CurrentPageNum;
            var items = pager.MoveNextPage();
            
            if (NextPageIsOk(items, pager.PageSize,pager.CurrentPageNum))
            {
                Console.WriteLine("进入下一页-----正确！");
                if (pager.CurrentPageNum-currentPage == 1)
                {
                    Console.WriteLine("当前页码增加1-------正确！");
                }
                else
                {
                    Console.WriteLine("当前页码为1-------失败！");
                }
            }
            else
            {
                Console.WriteLine("进入下一页-------失败！");
            }
        }


        static private void TestRemainderItems(SplitePage<StorageLocation> pager)
        {
             var totle = new StorageLocationCollection().StorageLocations.Count;
         
            while((totle/pager.PageSize)>0)
            {
                totle -= pager.PageSize;
                pager.MoveNextPage();
            }
             totle = new StorageLocationCollection().StorageLocations.Count;
            var lastLength = totle - pager.CurrentPageNum*pager.PageSize;
            if (lastLength == totle % pager.PageSize)
            {
                Console.WriteLine("进入最后一页-----正确！");
            }
            else
            {
                Console.WriteLine("进入最后一页------失败！");
            }

            var pagerNum = pager.CurrentPageNum;
            var items = pager.MoveNextPage();
            if (items.Count() == 0)
            {

                Console.WriteLine("最后一页下一页为空-----正确！");
                if (pagerNum == pager.CurrentPageNum)
                {
                    Console.WriteLine("最后一页为空当前页码不变------正确！");
                }
                else
                {
                    Console.WriteLine("最后一页为空当前页码不变------失败！");
                }
            }
            else
            {
                Console.WriteLine("最后一页下一页为空----失败！");
            }


            pagerNum = pager.CurrentPageNum;
            items = pager.MoveNextPage();
            if (pagerNum == pager.CurrentPageNum)
            {

                Console.WriteLine("第二次最后一页为空当前页码不变------正确！");

            }
            else
            {
                Console.WriteLine("第二次最后一页为空当前页码不变-----失败！");
            }
        }

        static private void TestGoToFirstPage(SplitePage<StorageLocation> pager)
        {
            var items = pager.MoveFirstPage();
            if (FirstPageIsOk(items, 5))
            {

                Console.WriteLine("再一次进入下一页------正确！");
                if (pager.CurrentPageNum == 0)
                {
                    Console.WriteLine("当前页码为0-------正确！");
                }
                else
                {
                    Console.WriteLine("当前页码为0-----失败！");
                }
            }
            else
            {
                Console.WriteLine("再一次进入下一页失败！");
            }

        }

        static private bool FirstPageIsOk(IEnumerable<StorageLocation> models, int size)
        {
            bool rel = true;
            var items = models.ToList();

            int i = 0;
            for (i = 0; i < items.Count; i++)
            {
                if (items[i].ProductName == (i + 1).ToString())
                {
                    continue;
                }
                else
                {
                    rel = false;
                }
            }
            if (i != size)
            {
                rel = false;
                Console.WriteLine("页数为" + size.ToString() + "------失败！");
            }
            else
            {
                Console.WriteLine("页数为" + size.ToString() + "------正确！");
            }
            return rel;
        }

        static private bool NextPageIsOk(IEnumerable<StorageLocation> models, int size, int currentPageNum)
        {
            bool rel = true;
            var items = models.ToList();
            if (items == null)
                return true;
            int i = 0;
            for (i = 0; i < items.Count; i++)
            {
                if (items[i].ProductName == (i + currentPageNum*size + 1).ToString())
                {
                    continue;
                }
                else
                {
                    rel = false;
                }
            }

            return rel;
        }


        static private void TestGoLastPage(SplitePage<StorageLocation> pager)
        {
            var models = pager.MoveLastPage().ToList();

            var result = true;
            for (int i = 0; i < models.Count() - 1; i++)
            {
                if (models[i].ProductName == (pager.CurrentPageNum * pager.PageSize + 1 + i).ToString())
                {
                    continue;
                }
                else
                {
                    result = false;
                }
            }
            if (result)
            {
                    Console.WriteLine("进入最后一页-----正确！");
                 var totle = new StorageLocationCollection().StorageLocations.Count;
                 if (pager.CurrentPageNum == totle / pager.PageSize)
                 {
                     Console.WriteLine("最后一页页号-----正确！");
                 }
                 else
                 {
                     Console.WriteLine("最后一页页号----错误！");
                 }
            }
            else
            {
                Console.WriteLine("进入最后一页-----错误！");
            }
        }


        static void PrintSplitLine()
        {
            Console.WriteLine("-----------------------------------------------------------");
        }



    }
}
