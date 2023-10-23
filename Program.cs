using System;

namespace Hata_yonetimi
{
    class Program
    {
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğin sayı: "+sayi);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: "+ ex.Message.ToString());
        }
        
        try
        {
            //int  a= int.Parse(null);
            //int a =int.Parse("Test");
            int a= int.Parse("-2000000"); 
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer giriniz.");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi uygun değil!");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz!");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem Tamamlandı");
        }
    }
}
}

