using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yEMEK_SİPARİŞ_HEASBI
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***          Yiyecekler           **          İçecekler         ***");
            Console.WriteLine("***   1- Et Döner Dürüm      10   **      2- Ayran        3.50  ***");
            Console.WriteLine("***   3- Tavuk Döner Dürüm   10   **      4- Kola         5.50  ***");
            Console.WriteLine("***   5- İskender            25   **      6- Fanta        5.50  ***");
            Console.WriteLine("***   7- İçli Köfte Porsiyon 50   **      8- Niğde Gazozu 9.50  ***");
            Console.WriteLine("*******************************************************************");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Alacağınız Ürün Numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());
            
                if (secim == 1)
                {
                    Console.WriteLine("Kaç Tane Et Dürüm");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = toplam + hesap;
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Kaç Tane Tavuk Dürüm");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = toplam + hesap;
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Kaç Porsiyon İskender");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = toplam + hesap;
                }
                else if (secim == 7)
                {
                    Console.WriteLine("Kaç Porsiyon İçli Köfte");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 50;
                    hesap = toplam + hesap;
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Kaç Tane Ayran");
                    adet = Convert.ToDouble(Console.ReadLine());
                        toplam = adet * 3.50;
                    hesap = toplam + hesap;
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Kaç Tane Kola");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.50;
                    hesap = toplam + hesap;
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Kaç Tane Fanta");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5.50;
                    hesap = toplam + hesap;
                }
                else if (secim == 8)
                {
                    Console.WriteLine("Kaç Tane Niğde Gazozu");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 9.50;
                    hesap = toplam + hesap;
                }
                else
                {
                    Console.WriteLine("Ürün Numarasını Doğru Girin (0,12)");
                    Console.WriteLine();
                    Console.WriteLine("Anthing Else ?");
                    string cevap = Console.ReadLine();
                    if (cevap == "hayır" || cevap == "Hayır" || cevap == "HAYIR")
                        break;
                }
                Console.WriteLine("Toplam Hesap: " + hesap);

            }
            

            
            Console.Read();
        }
    }
}
