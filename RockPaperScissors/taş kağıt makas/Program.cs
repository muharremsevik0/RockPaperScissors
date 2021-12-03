using System;

namespace taş_kağıt_makas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("taş kağıt makas oyununa hoşgeldiniz!");
            Console.ResetColor();
            int userscore = 0;
            int pcscore = 0;
        git:

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************");
            Console.WriteLine("TAŞ için T");
            Console.WriteLine("KAĞIT için K");
            Console.WriteLine("MAKAS için M ");
            Console.WriteLine("************************");
            Console.ResetColor();
            Random rnd = new Random();
            int pc_sayısı = rnd.Next(1,4);
           Console.WriteLine(pc_sayısı);
            
            string kullanıcı1;
            kullanıcı1 = Console.ReadLine();
            if(userscore!=5 && pcscore!=5)
            {
                if (kullanıcı1 == "t" || kullanıcı1 == "T" || kullanıcı1 == "k" || kullanıcı1 == "k" || kullanıcı1 == "m" || kullanıcı1 == "M")
                {



                    if (pc_sayısı == 1 && (kullanıcı1 == "t" || kullanıcı1 == "T"))
                    {
                        Console.WriteLine("PC=Taş  " + "  TAŞ");
                        Console.WriteLine("****OYUN BERABERE******");
                    }
                    else if (pc_sayısı == 1 && (kullanıcı1 == "k" || kullanıcı1 == "K"))
                    {
                        Console.WriteLine("Pc=Taş " + " Siz = KAĞIT");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("*****OYUNU KAZANDINIZ!*****  " );
                        Console.ResetColor();

                        userscore++;
                    }
                    else if (pc_sayısı == 1 && (kullanıcı1 == "M" || kullanıcı1 == "m"))
                    {
                        Console.WriteLine("Pc=Taş  " + "  Siz= Makas  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("******OYUNU KAYBETTİNİZ****");
                        Console.ResetColor();
                        pcscore++;
                    }
                    else if (pc_sayısı == 2 && (kullanıcı1 == "t" || kullanıcı1 == "T"))
                    {
                        Console.WriteLine("Pc= Kağıt " + "Siz= Taş  " );
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("******OYUNU KAYBETTİNİZ****");
                        Console.ResetColor();
                        pcscore++;
                    }
                    else if (pc_sayısı == 2 && (kullanıcı1 == "k" || kullanıcı1 == "K"))
                    {
                        Console.WriteLine("Pc=kağıt " + "   Siz=KAĞIT" );
                        Console.WriteLine("****OYUN  BERABERE******");
                    }
                    else if (pc_sayısı == 2 && (kullanıcı1 == "m" || kullanıcı1 == "M"))
                    {
                        Console.WriteLine("Pc=kağıt " + "Siz = makas  " );
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("*****OYUNU KAZANDINIZ!*****  ");
                        Console.ResetColor();
                        userscore++;
                    }

                    else if (pc_sayısı == 3 && (kullanıcı1 == "t" || kullanıcı1 == "T"))
                    {
                        Console.WriteLine("Pc=makas " + "Siz= taş  ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("*****OYUNU KAZANDINIZ!*****  ");
                        Console.ResetColor();
                        userscore++;
                    }

                    else if (pc_sayısı == 3 && (kullanıcı1 == "k" || kullanıcı1 == "K"))
                    {
                        Console.WriteLine("Pc=makas " + "Sizi=kağıt  " );
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("****OYUNU KAYBETTİNİZ****");
                        Console.ResetColor();
                        pcscore++;
                    }
                    else if (pc_sayısı == 3 && (kullanıcı1 == "m" || kullanıcı1 == "M"))
                    {
                        Console.WriteLine("Pc= makas " + "Siz=makas  " );
                        Console.WriteLine("****OYUN BERABERE******");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("pc score= " + pcscore + "  userscore= " + userscore);
                    Console.ResetColor();
                    goto git;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Yanlış karakter girdiniz lütfen işleminizi yeniden yapınız!");
                    Console.ResetColor();
                   
                    goto git;
                }
                
            }

            else if (userscore==5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******MAÇI KAZANDINIZ*******");
                Console.ResetColor();
            }
            else if (pcscore==5
                )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*****MAÇI KAYBETTİNİZ!******");
                Console.ResetColor();
            }














        }
    }
}
