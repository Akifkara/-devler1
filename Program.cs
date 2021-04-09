using System;

namespace MetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri();
            
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Akif";
            musteri1.Soyad = "Kara";
            musteri1.Sehir = "Giresun";
            musteri1.TcNo = 12345678910;




            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            
            Console.Write("Lütfen Adınızı Girin :");                       
            musteri.Ad = Console.ReadLine();

            Console.Write("Lütfen Soyadınızı Girin :");
            musteri.Soyad = Console.ReadLine();

           

            Console.Write("Lütfen İkametinizi Girin :");
            musteri.Sehir = Console.ReadLine();

            Console.WriteLine("------------------");
            Console.WriteLine("Tebrikler Hesabınız Eklendi");

     
            musteriManager.Listesi(musteri);

           
           




        }
    
    }

}
