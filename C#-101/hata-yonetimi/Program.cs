
try
{
    Console.WriteLine("Bir Sayı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş Olduğunuz Sayi : " + sayi);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}

finally
{
    Console.WriteLine("İşlem Tamamlandı");
}

//------------------

try
{
    // int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse("-2000000000000");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Boş Değer Girdiniz");
    Console.WriteLine(ex);
}

catch (FormatException ex)
{
    Console.WriteLine("Veri Tipi uygun Değil");
    Console.WriteLine(ex);
}

catch (OverflowException ex)
{
    Console.WriteLine("Cok Kucuk ya da Cok buyuk Deger Girdiniz");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem Basarı ile tamamlandı");
}



