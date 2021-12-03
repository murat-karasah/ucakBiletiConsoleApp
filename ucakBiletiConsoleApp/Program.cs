using System;

namespace ucakBiletiConsoleApp
{
    class Program
    {
        static int koltuksecim,sayac=0,sayacBus=0,ekoCheck,busCheck;
        static string[] eko = new string[12];
    //    static string[] eko = { "asd","asd" };

        static string[] bus = new string[8];
        static string isim, tus;
        
        static void Main(string[] args)
        {

            for (int i = 0; i < eko.Length; i++)
            {
                if (eko[i] != null)
                {
                    sayac++;
                }
                else if (eko.Length == sayac)
                {
                    Console.WriteLine("Tüm koltuklar dolu");
                }
                else
                {
                    sayac = 0;
                }
            }

            for (int i = 0; i < bus.Length; i++)
            {
                if (eko[i] != null)
                {
                    sayacBus++;
                }
                else if (bus.Length == sayacBus)
                {
                    Console.WriteLine("Tüm koltuklar dolu");
                }
                else

                {
                    sayacBus = 0;
                }
            }



            anaMenu();
            isimAl();
            koltukkontrol();
          
            rezervasyon();

            Main(null);
        }

       

        private static void anaMenu()
        {
            Console.WriteLine("Lütfen uçuş planlarından istediğinizi seçiniz:");
            Console.WriteLine("1-Ekonomi uçuş planları");
            Console.WriteLine("2-Bussines uçuş planları");
            tus = Console.ReadLine();
            if (tus=="1" || tus=="2")
            {

            }
            else
            {
                anaMenu();

            }
        }


        private static void isimAl()
        {
            Console.WriteLine("Koltuk seçimi yapmadan önce lütfen adınızı giriniz:");
            isim = Console.ReadLine();
        }

        private static void koltukkontrol()
        {
            
            if (tus=="1")
            {

                if (sayac!=eko.Length)
                {
                    for (int i = 0; i < eko.Length; i++)
                    {
                        if (eko[i] == null)
                        {
                            Console.WriteLine($"{i}. koltuk boş");
                        }
                        else
                        {

                            Console.WriteLine($"{i}. koltuk {eko[i]} tarafından rezerve edilmiştir.");

                        }

                    }
                }
                else
                {
                    Console.WriteLine("koltuklar dolu");
                }
                    
                
            }
            else
            {
                
               
                    for (int i = 0; i < bus.Length; i++)
                    {
                        if (bus[i] == null)
                        {
                            Console.WriteLine($"{i}. koltuk boş");
                        }
                        else
                        {

                            Console.WriteLine($"{i}. koltuk {bus[i]} tarafından rezerve edilmiştir.");

                        }
                       
                    
                }
                
            }
            Console.WriteLine("Rezerve etmek istediğiniz koltuğun numarasını giriniz:");
            koltuksecim = Convert.ToInt32(Console.ReadLine());
          


        }

        private static void rezervasyon()
        {
            

            if (tus=="1")
            {
                if (eko[koltuksecim]==null)
                {
                    eko[koltuksecim] = isim;
                }
                else
                {
                    Console.WriteLine("Dolu olan bir koltuğu seçtiniz");
                }
            }
            else
            {
                if (bus[koltuksecim] == null)
                {
                    bus[koltuksecim] = isim;
                }
                else
                {
                    Console.WriteLine("Dolu olan bir koltuğu seçtiniz");
                }
            }
        }

    }
}
