#region Kim 10.000 TL Kazanmak İster Programı ##1

{
    Console.WriteLine("Yarışmamıza Hoşgeldiniz!, Lütfen Adınız ve Soyadınızı söyleyiniz!");
    string adSoyad = Console.ReadLine();
    Console.WriteLine("Hoşgedin " + adSoyad + " Yarışmamıza nereden katılıyorsunuz?");
    string sehir = Console.ReadLine();
    Console.WriteLine("Kaç yaşındasınız?");
    string yas0 = Console.ReadLine();
    int yas = int.Parse(yas0);
    Console.WriteLine(adSoyad + " Eğitim durumunuz nedir?");
    string uni = Console.ReadLine();
    Console.WriteLine("Çok güzel bende " + uni + " 'den mezun olmuştum.");
    Console.WriteLine("Hazırsan yarışmaya başlıyoruz");
    string cevap = Console.ReadLine();
    Console.WriteLine("Türkiye'nin Başkenti neresidir?");
    string soru1 = Console.ReadLine();

    while (true)
    {
        if (soru1 == "Ankara")
        {
            Console.WriteLine("Tebrikler 500 TL Kazandınız.");
        }
        else
        {
            Console.WriteLine("Üzgünüm, Yanlış Cevap verdiniz. Kazanılan Para Ödülü 0 TL");
            break;
        }

        Console.WriteLine("Trabzon'un plaka kodu nedir?");
        string soru2 = Console.ReadLine();
        int soru02 = int.Parse(soru2);
        if (soru02 == 61)
        {
            Console.WriteLine("Tebrikler 2500 TL Kazandınız.");
        }
        else
        {
            Console.WriteLine("Üzgünüm Cevabınız Yanlış. Kazanılan Para Ödülü 0 TL");
            break;
        }

        Console.WriteLine("Baraj Soruna geldik. Hangisinin yazımı doğrudur");
        Console.WriteLine("A: C Charp");
        Console.WriteLine("B: C#");
        Console.WriteLine("C: CSarp");
        Console.WriteLine("D: SiSharp");
        string soru3 = Console.ReadLine();
        if (soru3 == "B")
        {
            Console.WriteLine("Cevabınız Doğrudur. Kazanılan Para ödülü 5.000 TL");
        }
        else
        {
            Console.WriteLine("Cevabanız Yanlış. Kazanılan Para Ödülü 0 TL");
            break;
        }

        Console.WriteLine("Evet Finalden önceki sorumuza geldik. Aslan sembolü hangi banka'ya aittir.");
        string soru4 = Console.ReadLine();
        if (soru4 == "ING")
        {
            Console.WriteLine("Cevabınız Doğrudur. Kazandığınız Para Ödülü 7.500 TL");
        }
        else
        {
            Console.WriteLine("Cevabınız Yanlıştır. " + adSoyad + " Malesef seni 2.500 TL ile uğurluyoruz");
            break;
        }
        Console.WriteLine("Final sorusuna geldik. Türkiye'nin 5.Özel Bankası hangisidir?");
        string soruFinal = Console.ReadLine();
        if (soruFinal == "Denizbank")
        {
            Console.WriteLine("Tebrikler 10.000 TL kazandınız.");
        }
        else
        {
            Console.WriteLine("Cevabınız Yanlıştır. " + adSoyad + " Malesef seni 2.500 TL ile uğurluyoruz");
            break;
        }
    }

}
Console.ReadKey();

#endregion