using System;

namespace alan_hesaplama;

abstract class Sekil
{
    internal abstract void OlcuAl();
    internal abstract double CevreHesapla();
    internal abstract double AlanHesapla();

    internal bool Degerlendir(params int[] olculer)
    {
        for (int i = 0; i < olculer.Length; i++)
        {
            if (olculer[i] < 1)
                return false;
        }
        return true;
    }

    internal int Kontrol(string olcuStr)
    {
        string mesaj = null;
        int olcu = 0;
        
        try
        {
            olcu = int.Parse(olcuStr);
            if (!Degerlendir(olcu))
                throw new Exception();
        }
        catch (FormatException)
        {
            mesaj = "Ölçü bir tam sayı olmalı!";
        }
        catch (Exception)
        {
            mesaj = "Ölçü 0'dan büyük olmalı!";
        }

        Console.WriteLine(mesaj);
        return olcu;
    }

    internal virtual void SonucYaz(string sekil)
    {
        Console.WriteLine($"\n {sekil}; \n Çevresi: {CevreHesapla()} birim \n Alanı: {AlanHesapla()} birim^2 \n");
    }
}