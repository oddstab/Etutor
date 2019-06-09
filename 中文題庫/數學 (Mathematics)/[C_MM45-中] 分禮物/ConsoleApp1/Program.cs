using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Xml;



namespace CSharpTest

{

    class program

    {

        static void Main(string[] args)

        {

            List<string> list = new List<string>();

            string[] li = Console.ReadLine().Split(',');//使用英文状态下输入

            for (int i = 0; i < li.Length; i++)

            {

                list.Add(li[i].ToString());

            }

            getQ(list, 0, li.Length);

            Console.ReadKey();

        }



        /// <summary>

        /// 对数组进行全排列

        /// </summary>

        /// <paramname="lsArray">要进行全排列的数组</param>

        /// <paramname="begin">进行全排列的开始下标</param>

        /// <param name="end">进行全排列的结束下标</param>

        static void getQ(List<string> lsArray, int begin, int end)

        {

            if (begin == end)

            {

                Console.WriteLine(string.Join(",", lsArray));

            }

            for (int i = begin; i < end; i++)

            {

                if (IsSwap(lsArray, begin, i))

                {

                    Swap(lsArray, begin, i);

                    getQ(lsArray, begin + 1, end);

                    Swap(lsArray, begin, i);

                }

            }

        }



        /// <summary>

        /// 判断是否重复

        /// </summary>

        /// <paramname="pchar"></param>

        /// <paramname="nBegin"></param>

        /// <paramname="nEnd"></param>

        /// <returns></returns>

        public static bool IsSwap(List<string> pchar, int nBegin, int nEnd)
        {
            for (int i = nBegin; i < nEnd; i++)

                if (pchar[i] == pchar[nEnd])

                    return false;

            return true;
        }



        /// <summary>

        /// 交换数组中指定元素

        /// </summary>

        /// <paramname="lsArray"></param>

        /// <paramname="x"></param>

        /// <paramname="y"></param>

        static void Swap(List<string> lsArray, int x, int y)

        {

            string t = lsArray[x];

            lsArray[x] = lsArray[y];

            lsArray[y] = t;

        }

    }

}