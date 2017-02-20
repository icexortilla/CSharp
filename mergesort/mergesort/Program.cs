/***
 * Written by Ice Xortilla
 * Date: 2017-02-20
 * 
***/
using System;

namespace mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 20, 39, 1, 2, 50, 3, 5, -1 };
            int[] tmp = new int[a.Length];
            printarray(a);
            mergesort(a, tmp, 0, a.Length - 1);
            printarray(a);
            Console.ReadLine();
            
        }

        static void printarray(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static void mergesort(int[] a,int[] tmp,int left,int right)
        {
            if (left < right) { 
            int center = (left + right) / 2;
            mergesort(a, tmp, left, center);
            mergesort(a, tmp, center + 1, right);
            merge(a, tmp, left, center + 1, right);
            }
        }

        static void merge(int[] a,int[] tmp, int left,int right, int rightend)
        {
            int leftend = right - 1;
            int tmpPos = left;
            int numelm = rightend - left + 1;

            while (left <= leftend && right <= rightend)
                if (a[left].CompareTo(a[right]) <= 0)
                    tmp[tmpPos++] = a[left++];
                else
                    tmp[tmpPos++] = a[right++];

            // Lets copy the remaining first half
            while (left <= leftend)
                tmp[tmpPos++] = a[left++];

            // Lets copy the remaining right half
            while (right <= rightend)
                tmp[tmpPos++] = a[right++];

            for (int i = 0; i < numelm; i++) {
                a[rightend] = tmp[rightend];
                rightend--;
                    }


        }
    }
}
