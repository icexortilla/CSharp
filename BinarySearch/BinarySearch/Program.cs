/***
 * Written by Ice Xortilla
 * Date: 2017-02-20
 * 
***/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    enum SearchResult
    {
        Found,
        NotFound
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int key = 5;

            Console.WriteLine(search(a, key));
            Console.WriteLine(search(a, -1));;
            Console.ReadLine();

        }


        /***
         * Search a sorted list to find the given key
        ***/
        public static SearchResult search(int[] a,int searchkey)
        {

            int low = 0;
            int high = a.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (a[mid].CompareTo(searchkey) < 0)
                    low = mid + 1;
                else if (a[mid].CompareTo(searchkey) > 0)
                    high = mid - 1;
                else
                    return SearchResult.Found;

            }


            return SearchResult.NotFound;

        }
    }
}
