using System;

namespace alan_hesaplama;

class Dikdortgen : Sekil
{
    private int[] kenarOlcu;

    internal Dikdortgen()
    {
        OlcuAl();

        if(Degerlendir(kenarOlcu))
            SonucYaz("Dikdörtgen");
    }

    internal override double AlanHesapla()
    {
        return kenarOlcu[0] * kenarOlcu[1];
    }

    internal override double CevreHesapla()
    {
        return 2 * (kenarOlcu[0] + kenarOlcu[1]);
    }

    internal override void OlcuAl()
    {
        kenarOlcu = new int[2];
        string[] kenarIsim = new string[] {"taban", "yükseklik"};
        Console.WriteLine("Dikdörtgen'in kenar uzunluklarını girin!");
        Yardimci.Yazdir(Sabitler.Cizgi);
        for (int i = 0; i < kenarOlcu.Length; i++)
        {
            Console.Write(kenarIsim[i] + ": ");
            int olcu = Kontrol(Console.ReadLine());
            if (Degerlendir(olcu))
                kenarOlcu[i] = olcu;
            else
                break;
        }
    }
}