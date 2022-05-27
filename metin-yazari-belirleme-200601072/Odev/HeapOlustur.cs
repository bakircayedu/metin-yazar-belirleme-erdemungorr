using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Odev
{
    public class HeapOlustur
    {
        //https://www.geeksforgeeks.org/heap-sort/?ref=lbp sitesinden yararlanılmistir.
        public void heapify(string[] arr, int n, int i)
        {
            int largest = i;
            int sol = 2 * i + 1;
            int sag = 2 * i + 2;


            if (sol < n && string.Compare(arr[sol], arr[largest]) < 0)
                largest = sol;

            if (sag < n && string.Compare(arr[sag], arr[largest]) < 0)
                largest = sag;

            if (largest != i)
            {
                string swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;


                heapify(arr, n, largest);
            }
        }


        public void buildHeap(string[] arr, int n)
        {
            //Aynı olan kelimeleri bulup eliyoruz.
            StringBuilder ekle = new StringBuilder();
            String[] uniqueListString = arr.Distinct().ToArray();

            foreach (string item in uniqueListString)
            {
                ekle.Append(item + ",");
            }
            Console.WriteLine(ekle.Remove(ekle.Length - 1, 1));

            int startIdx = (n / 2) - 1;


            for (int i = startIdx; i >= 0; i--)
            {
                heapify(arr, n, i);
            }
        }



        public void printHeap(string[] arr, int n)
        {

            for (int i = 0; i < n; ++i)
                MessageBox.Show(arr[i] + " ");
        }
        public void sort(string[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                string temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }
    }
}


    

