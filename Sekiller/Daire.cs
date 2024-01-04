using System;

namespace alan_hesaplama;

class Daire : Sekil
{
    private static double pi;
    private int r;

    static Daire()
    {
        pi = Math.PI;
    }

    internal Daire()
    {
        OlcuAl();

        if (Degerlendir(r))
            SonucYaz("Daire");
    }

    internal override double CevreHesapla()
    {
        return 2 * pi * r;
    }

    internal override double AlanHesapla()
    {
        return pi * (r * r);
    }

    internal override void OlcuAl()
    {
        Console.Write("Daire'nin yarıçapını girin: ");
        r = Kontrol(Console.ReadLine());
    }
}