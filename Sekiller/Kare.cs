using System;

namespace alan_hesaplama;

class Kare : Sekil
{
    private int kenar;

    internal Kare()
    {
        OlcuAl();

        if (Degerlendir(kenar))
            SonucYaz("Kare");
    }

    internal override double AlanHesapla()
    {
        return kenar * kenar;
    }

    internal override void OlcuAl()
    {
        Console.Write("Kare'nin kenar uzunluğunu girin: ");
        kenar = Kontrol(Console.ReadLine());
    }

    internal override double CevreHesapla()
    {
        return kenar * 4;
    }
}