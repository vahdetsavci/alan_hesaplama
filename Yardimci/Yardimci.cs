using System;

namespace alan_hesaplama;

enum Sabitler
{
    Cizgi,
    Gecersiz
}

static class Yardimci
{
    static string[] strings;

    static Yardimci()
    {
        strings = new string[]
        {
            "-------------------------------------------------",
            "Geçersiz seçim yaptınız!"
        };
    }

    internal static void Yazdir(Sabitler s)
    {
        string mesaj = strings[(int)s];
        Console.WriteLine(mesaj);
    }
}