// Burada 10 kere aşağıda belirtilen metni yazdırıyorum.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// Burada 1 ile 20 arasındaki sayıları konsola yazdırıyorum.

for (int i = 2; i < 20; i++)
{
    Console.WriteLine($"Sayı -> {i}");
}

// Burada 1 ile 20 arasındaki çift sayıları konsola yazdırıyorum.

for (int i = 2; i < 20; i += 2)
{
    Console.WriteLine($"Sayı -> {i}");
}

// Burada 50 ve 150 arasındaki sayıların toplama işlemini yapıyor ve konsol ekranına yazdırıyor.

int toplam = 0;

for (int i = 51; i < 150; i++)
{
   toplam += i;
}
Console.WriteLine($"Toplam -> {toplam}");

// Burada 1 ile 120 arasındaki tek ve çift sayılarını if karar yapısıyla ayırıp topluyorum ve daha sonra yazdırıyorum.

int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i < 120; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}

Console.WriteLine($"Tek sayıların toplamı -> {tekToplam}");
Console.WriteLine($"Çift sayıların toplamı -> {ciftToplam}");