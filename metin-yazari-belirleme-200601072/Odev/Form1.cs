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
using System.Security.Cryptography;

namespace Odev
{
    public partial class Form1 : Form
    {


      

            






        EStack<string> stackCumleler = new EStack<string>();
        EStack<string> stackKelimeler = new EStack<string>();
        EStack<string> stackKelimeler2 = new EStack<string>();
        




        public Form1()
        {
            InitializeComponent();

        }

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            //Dosya seçme ve textBox'a yazdırma işlemi
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);

                string veriSatiri = sr.ReadLine();

                while (veriSatiri != null)
                {
                    txtMetinOkuma.Text = veriSatiri;
                    veriSatiri = sr.ReadLine();
                }
                //Dosya yolu gösterme
                lblSecilenYol.Text = openFileDialog.FileName;
            }

            

        }

       

        private void btnStackeOku_Click(object sender, EventArgs e)
        {

            // Cümleleri Stack'e linked list ile implement ediyoruz. Gerekli bilgileri veriyoruz.

            string[] cumleler = txtMetinOkuma.Text.Split('.', '\n');
            int kelimeSayisi = 0;
            int cumleSayisi = 0;
            int ortKelimeIcin = 0;
            for (int i = 0; i < (cumleler.Length-1); i++)
            {
                kelimeSayisi = 0;
                cumleSayisi++;
                stackCumleler.Push(cumleler[i]);
                   string[] kelimeler = cumleler[i].Split(' ', '\n');

                
                    for (int j = 0; j < (kelimeler.Length - 1); j++)
                    {    
                    
                    kelimeSayisi++;
                    stackKelimeler.Push(kelimeler[j]);
                    
                   
                    }
                
                ortKelimeIcin = ortKelimeIcin + kelimeSayisi;
                MessageBox.Show(cumleSayisi + ".cümledeki kelime sayisi : " + kelimeSayisi);
            }
            float ortKelimeSayisi = ortKelimeIcin / cumleSayisi;
            MessageBox.Show("Ortalama Kelime Sayısı : " + (ortKelimeSayisi));


            listBoxKelime.Items.Clear();
            string cumle;
            string[] kelimeSikligi;
            List<string> tekil = new List<string>();
            cumle = txtMetinOkuma.Text;
            cumle = cumle.ToLower();
            cumle = cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "");
            kelimeSikligi = cumle.Split(' ');

            for (int i = 1; i < kelimeSikligi.Length; i++)
            {
                if (tekil.Contains(kelimeSikligi[i]) == false)
                {
                    tekil.Add(kelimeSikligi[i]);
                }
            }

            
            foreach (string k in tekil)
            {
                

                int sayac = 0;
                for (int i = 0; i < kelimeSikligi.Length; i++)
                {
                    
                    if (kelimeSikligi[i] == k)
                    {
                        sayac++;
                    }
                }
                listBoxKelime.Items.Add(k + "->  kullanım sıklıgı : " + sayac + " adettir.");
              
            }

            

        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {



            string[] kelimelerAgaca = txtMetinOkuma.Text.Split(' ', '\n');
            for (int j = 1; j < (kelimelerAgaca.Length - 1); j++)
                stackKelimeler2.Push(kelimelerAgaca[j]);
            //Stack'e puşladığımız kelimeleri diziye çekiyoruz.
            string[] arr = stackKelimeler2.ToArray();

            int n = arr.Length;         
            //Diziyi String Heap'e çeviriyoruz.
            HeapOlustur bd =  new HeapOlustur();
            bd.buildHeap(arr, n);
            bd.printHeap(arr, n);
            bd.sort(arr);
            
        }
        private void txtMetinOkuma_TextChanged(object sender, EventArgs e)
        {




        }

        private void listBoxKelime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String[] arr = stackKelimeler.ToArray();
            HashTable hash = new HashTable(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                int indis = 0;
                string kelime = arr[i];
                indis= hash.hash(kelime, arr.Length);
                hash.ekle(indis, kelime);
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
