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

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 54, 26, 93, 17, 77, 31, 44, 55, 20 };
            int[] tmp = new int[a.Length];

            printarray(a);
            quicksort(a, 0, a.Length - 1);
            printarray(a);
            Console.ReadLine();
        }

        static void printarray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static void quicksort(int[] a,int low,int hi)
        {
            if (low < hi) { 
              int mid = partition(a, low, hi);
                quicksort(a, low, mid - 1);
                quicksort(a, mid + 1,hi);
            }
        }


        static int partition(int[] a, int low,int hi)
        {
            int pivot = a[hi];
            int i = low - 1;
            int tmp;
            for (int j = low; j <= hi - 1; j++)
            {
                if (a[j] < pivot)
                {
                    i = i + 1;
                    tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                }
            }

            tmp = a[i+1];
            a[i+1] = a[hi];
            a[hi] = tmp;
            return i + 1;
        }
    }
}
