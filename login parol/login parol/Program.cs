using System;

namespace login_parol
{
    class Program
    {
        static void Main(string[] args)
        {
            int giris_haqqi = 3;

            while (true)
            {
                Console.WriteLine("Logini Daxil Edin: ");
                string login = Console.ReadLine();

                Console.WriteLine("Sifreni Daxil Edin: ");
                string sifre = Console.ReadLine();
                if (login == "Nazim Rajabov" && sifre == "224466nr")
                {
                    Console.WriteLine("Hesabiniza muveffeqiyyetle giris edildi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz melumatlar duzgun deyil");
                    if (giris_haqqi >= 0)
                    {
                        giris_haqqi--;
                    }
                    if (giris_haqqi == 0)
                    {
                        Console.WriteLine("Girisiniz Muveqqeti Bloklanmisdir.");
                        break;

                        //assdfasdfasdfasdasdfs
                    }
                }
            }

        }
    }
}