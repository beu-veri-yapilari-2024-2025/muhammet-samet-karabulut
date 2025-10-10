using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevler
{
    internal class Program
    {
        //Recursive ikili arama: 
        public static int Search(int[] dizi, int aradigimizSayi, int sol, int sag) //sola sıfır verilir 0 dan başladığı için saga ise dizi.Length -1 verilir.
        {
            if (sag>=sol)
            {
                int orta = sol + (sag - sol) / 2; //ortayı buluyoruz
                if (dizi[orta]==aradigimizSayi) //ortaya eşit mi ? 
                {
                    return orta;
                }
                else if (dizi[orta] > aradigimizSayi) //ortadaki diziden küçük mü aradığımız sayı 
                {
                    return Search(dizi, aradigimizSayi, sol, orta - 1); //küçükse sayımız solda kalıyordur ona göre kendini tekrar çağırıyor.
                }
                else
                {
                    return Search(dizi,aradigimizSayi,orta+1, sag); // büyükse sayımız sağda kalıyordur ona göre kendini tekrar çağır.
                }
            }
            return -1; //  hiç biri olmuyorsa -1 döner sayı yoktur
        }
        static void Main(string[] args)
        {

            //dizideki elemanların toplamı
            int[] dizi1 = { 1, 2, 3 };
            int toplam = 0;
            for (int i = 0; i < dizi1.Length; i++)
            {
                toplam += dizi1[i];
            }
            Console.WriteLine($"{toplam}");
            Console.ReadKey();


            //matris çarpımı
            int[,] dizi =
            {
                { 1,2,3},{4,5,6 }
            };
            int[,] dizi2 =
            {
                { 7,8},{9,3},{2,1 }
            };

            int satir1 = dizi.GetLength(0);  
            int sutun1 = dizi.GetLength(1);  
            int satir2 = dizi2.GetLength(0);
            int sutun2 = dizi2.GetLength(1);

            if (sutun1 != satir2)
            {
                Console.WriteLine("Matrisler çarpılamaz!");
                return;
            }

            int[,] sonuc = new int[satir1, sutun2];

            for (int i = 0; i < satir1; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    for (int k = 0; k < sutun1; k++)
                    {
                        sonuc[i, j] += dizi[i, k] * dizi2[k, j];
                    }
                }
            }

            Console.WriteLine("Matris çarpımının sonucu:");
            for (int i = 0; i < satir1; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    Console.Write(sonuc[i, j] + " ");
                }
                Console.WriteLine();
            }
            //dizideki elemanın aranması 
            int[] dizi3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };



            Console.ReadKey();
        }
    }
}
