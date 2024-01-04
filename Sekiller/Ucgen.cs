using System;

namespace alan_hesaplama;

class Ucgen : Sekil
{
    private int[] kenarOlcu;
    private double cevre;

    internal Ucgen()
    {
        OlcuAl();

        if (Degerlendir(kenarOlcu))
            SonucYaz("Üçgen");
    }

    internal override void OlcuAl()
    {
        kenarOlcu = new int[3];
        string[] kenarIsim = new string[] {"sağ", "taban", "sol"};

        Console.WriteLine("Üçgen'in kenar uzunluklarını girin!");
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

    internal override double CevreHesapla()
    {
        return cevre = kenarOlcu[0] + kenarOlcu[1] + kenarOlcu[2];
    }

    internal override double AlanHesapla()
    {
        double s = cevre / 2;
        return Math.Sqrt(s * (s - kenarOlcu[0]) * (s - kenarOlcu[1]) * (s - kenarOlcu[2]));
    }
}