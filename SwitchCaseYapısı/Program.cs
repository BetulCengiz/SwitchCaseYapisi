using System;

namespace SwitchCaseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {

            // switch içindeki değişken tüm case yapıları ile karşılaştırılır hangisiyle eşleşiyorsa o çıktıyı verir.
            // caseler ile eşleşmiyorsa default(varsayılan) yapısı eklenebilir.
            //break blokdan çıkış için gereklidir

            //int sayi;
            //Console.WriteLine("1 ile 7 arasında bir sayı giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //switch(sayi)
            //{
            //    case 1: Console.WriteLine("Gün = Pazartesi");
            //        break;
            //    case 2: Console.WriteLine("Gün = Salı");
            //        break;
            //    case 3: Console.WriteLine("Gün = Çarşamba");
            //        break;
            //    case 4: Console.WriteLine("Gün = Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Gün = Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Gün = Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Gün = Pazar");
            //        break;
            //    default: Console.WriteLine("Hatalı gün girişi");
            //        break;


            string mevsim;
            Console.WriteLine("Bir mevsim giriniz(küçük harfler ile)");
            mevsim = Console.ReadLine();


            switch (mevsim)
            {
                case "yaz": Console.WriteLine("Yaz mevsimi ayları= Haziran,Temmuz,Ağustos");
                    break;
                case "kış":
                    Console.WriteLine("Kış mevsimi ayları= Aralık,Ocak,Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("İlkbahar mevsimi ayları= Mart,Nisan,Mayıs");
                    break;
                case "sonbahar":
                    Console.WriteLine("Sonbahar mevsimi ayları= Eylül,Ekim,Kasım");
                    break;
                default: Console.WriteLine("Girdiğiniz bir ay değil");
                    break;
            }








        }       
        }
    }

