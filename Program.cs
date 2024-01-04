using System;

namespace alan_hesaplama;

class Program
{
    static void Main(string[] args)
    {
        Baslangic:
        Console.WriteLine("\n Çevre / Alan hesabı yapmak istediğiniz şekli seçin! \n 1. Daire \n 2. Üçgen \n 3. Kare \n 4. Dikdörtgen");
        Yardimci.Yazdir(Sabitler.Cizgi);
        
        switch (Console.ReadLine())
        {
            case "1":
                new Daire();
                break;
            case "2":
                new Ucgen();
                break;
            case "3":
                new Kare();
                break;
            case "4":
                new Dikdortgen();
                break;
            default:
                Yardimci.Yazdir(Sabitler.Gecersiz);
                break;
        }

        Tekrar:
        Console.WriteLine();
        Console.Write("Hesap yapmaya devam etmek istiyor musunuz? [E] Evet / [H] Hayır \n");
        Yardimci.Yazdir(Sabitler.Cizgi);
        switch(Console.ReadLine().ToLower())
        {
            case "e":
                goto Baslangic;
            case "h":
                break;
            default:
                Yardimci.Yazdir(Sabitler.Gecersiz);
                goto Tekrar;
        }
    }
}
