using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entites
{
    public class Bank
    {
        public decimal balance;

        public Bank()
        {
            balance = 100;
        }

        public decimal Withdraw()
        {
            Console.Clear();
            Console.Write("Çekmek istediğiniz miktarı giriniz: ");
            string moneyStr = Console.ReadLine();

            decimal money = Convert.ToDecimal(moneyStr);

            if (balance < money)
            {
                Console.WriteLine("YETERSIZ BAKIYE");
                //balance = 0; //bakiyemizin hepsini cekeriz ve cektigimiz degeri doneriz
                //return balance;
            }
            else
            {
                balance = balance - money;
                Console.WriteLine($"HESABINIZDAN {money} TL PARA CEKILMISTIR.\nKALAN BAKIYE: {balance} TL ");
                //return money;
            }
            return balance;
        }

        public decimal AddMoney()
        {
            Console.Clear();
            Console.Write("Yatirmak istediginiz miktari giriniz: ");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            balance = balance + money;
            Console.WriteLine($"BAKIYENIZ {balance} TL OLARAK GUNCELLENMISTIR.");
            return balance;
        }

        public void BankScreen()
        {
            Console.WriteLine("Zehra Bankasına Hoş Geldiniz.");
            Console.WriteLine("1. Hesap İşlemleri");
            Console.WriteLine("2. Çıkış");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("1.Hesaptan Para Cekme");
                    Console.WriteLine("2.Hesaba Para Ekleme");
                    Console.WriteLine("3.Bakiye Goruntule");
                    Console.WriteLine("4.Cikis");

                    string press = Console.ReadLine();
                    
                    switch (press)
                    {
                        case "1":
                            Withdraw();
                            break;
                        case "2":
                            AddMoney();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine($"Mevcut bakineyiz: {balance}TL");
                            break;
                        case "4":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Hatali bir tusa bastiniz");
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Hatali bir tusa bastiniz");
                    break;
            }
        }
    }
}
