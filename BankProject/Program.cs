using BankProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Banka sınıfı oluşturulacak.
            // BU sınıfın bakiye adında bir fieldı olacak
            // Para çekme ve para yatırma işlemleri için metotlar bulunacak
            // Para çekildiğinde 0 ın altına düşmeme durumu uygulanmalı

            // Banka için konsol ekranı yazılacak.
            // Hesap işlemleri ve çıkış seçenekleri olacak
            // Hesap işlemlerine tıklandığında; para çekme, para ekleme, bakiye görüntüleme ekranları yazılacak.

            Bank bank = new Bank();
            bank.BankScreen();



            Console.ReadKey();
        }
    }
}
