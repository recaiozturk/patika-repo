
//Ekrandan girilen sayıya kadar tek sayıları ekrana yazdırır
int sayac = int.Parse(Console.ReadLine());

for (int i = 1; i < sayac; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}


//1 ile 100 arasındaki tek ve çift sayıların kendiaralarındaki toplapı ekrana yazdırır
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1)
    {
        tekToplam += i;
    }
    else
    {
        ciftToplam += i;
    }
}

Console.WriteLine("Tek Toplam:" + tekToplam);
Console.WriteLine("Tek Toplam:" + ciftToplam);

//break,contunie
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

//break,contunie
for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

