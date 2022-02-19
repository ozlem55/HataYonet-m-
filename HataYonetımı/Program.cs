using System;

namespace HataYonetımı
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı griniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");    
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2134567891011");

            }
            catch (ArgumentException ax)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ax);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok büyük  değer girdiniz");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
