using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;

            // Expression (kontrole etmek istediğimiz koşul)
            switch (mounth)
            {
                case 1:
                   Console.WriteLine("Ocak Ayindasiniz.");
                   break;
                case 2:
                   Console.WriteLine("Şubat Ayindasiniz.");
                   break;
                case 4:
                   Console.WriteLine("Nisan Ayindasiniz.");
                   break;
                case 3:
                   Console.WriteLine("Mart Ayindasiniz.");
                   break;
                default:
                   Console.WriteLine("Yanliş Veri Girdiniz!");
                break;
            }

            switch (mounth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kiş Ayindasiniz!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Ayindasiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayindasiniz!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayindasiniz!");
                    break;
                default:
                break;
            }
        }
    }
}