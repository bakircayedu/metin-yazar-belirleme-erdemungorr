using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public class HashTable
    {
        public int size;
        public HashNode[] dizi;

        public HashTable(int size)
        {
            this.size = size;
            dizi = new HashNode[size];
            for (int i = 0; i < size; i++)
            {
                dizi[i] = new HashNode();
            }

        }

       public int hash(string key,int tableSize)
        {
            int hashVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashVal += key[i];
            }
            return hashVal % tableSize;
        }



        public void ekle(int key, string kelime)
        {
            HashNode eleman = new HashNode(key, kelime);
            int indis = hash(kelime,size);
            HashNode temp = dizi[indis];

            while (temp.next!=null)
            {
                temp = temp.next;
            }
            temp.next = eleman;
            MessageBox.Show(key + " " + kelime + " eklendi.");
      
        }

    }
}
