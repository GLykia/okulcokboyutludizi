using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulcokboyutludizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string okuladi = "";
            string sube = "";
            Console.WriteLine("Okul Adedini giriniz");
            int okuladet = 0;

            bool otut = int.TryParse(Console.ReadLine(), out okuladet);
            while (!otut)
            {
                Console.WriteLine("Tekrar okul adedi giriniz");
            }

            Console.WriteLine("Sınıf adetlerini giriniz");
            int sinifadet = 0;
            while (!int.TryParse(Console.ReadLine(), out sinifadet))
            {
                Console.WriteLine("Tekrar sınıf adedi giriniz.");
            }

            Console.WriteLine("Sınıfta bulunabilecek maksimum öğrenci adedini giriniz");
            int ogrenciadet = 0;
            while (!int.TryParse(Console.ReadLine(), out ogrenciadet))
            {
                Console.WriteLine("Tekrar sınıf adedi giriniz");
            }
            
            string[,,,] okullar = new string[okuladet, sinifadet, ogrenciadet, 3];
            for (int i = 0; i < okullar.GetLength(0); i++)
            {
                Console.Write("{0}. Okulun adını giriniz:",i+1);
                okuladi = Console.ReadLine();
                for (int j = 0; j < okullar.GetLength(1); j++)
                {
                    Console.WriteLine("{0} Şube ismi giriniz",j+1);
                    sube = Console.ReadLine();
                    for (int k = 0; k < okullar.GetLength(2); k++)
                    {
                        Console.WriteLine("{0} öğrenci ismi giriniz", k + 1);
                        okullar[i, j, k, 0] = okuladi;
                        okullar[i, j, k, 1] = sube;
                        okullar[i, j, k, 2] = Console.ReadLine();
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < okullar.GetLength(0); i++)
            {
                Console.WriteLine("Okul adı: {0}\n",okullar[i,0,0,0]);
                for (int j = 0; j < okullar.GetLength(1); j++)
                {
                    Console.WriteLine("Şube: {0}", okullar[i, j, 0, 1]);
                    Console.WriteLine("**********************");
                    for (int k = 0; k < okullar.GetLength(2); k++)
                    {
                        Console.WriteLine("Öğrenci Adı Soyadı: {0}", okullar[i,j,k,2]);
                    }
                }
            }
        }
    }
}
