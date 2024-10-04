using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("*****  FİYAT LİSTESİ  *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.85;
            //strawberryPrice = 30.25;
            //potatoPrice = 56.25;
            //tomatoPrice = 13.40;

            //Console.WriteLine("------ Elma Birim Fiyatı: " + applePrice + " t ");
            //Console.WriteLine("------ Portakal Birim Fiyatı: " + orangePrice + " t ");
            //Console.WriteLine("------ Çilek Birim Fiyatı: " + strawberryPrice + " t ");
            //Console.WriteLine("------ Patates Birim Fiyatı: " + potatoPrice + " t ");
            //Console.WriteLine("------ Domates Birim Fiyatı: " + tomatoPrice + " t ");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1245;
            //orangeGram = 2650;
            //strawberryGram = 0.750;
            //potatoGram = 4.850;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan ürün: Elma - " +applePrice +" - Gramaj: "+ appleGram + " - Toplam tutar: "+ appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveeriş Toplam Tutar: "+ shoppingTotalPrice + "TL");

            //Console.Read();


            #endregion

            #region char değişkenleri

            //char symbol;
            //symbol = 'a';


            //Console.WriteLine(symbol);





            //Console.Read();
            #endregion


            #region klavyeden veri girişleri


            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();


            //Console.Write("Yolcu SoyAdı: ");
            //passengerSurname = Console.ReadLine();


            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Bilgisi:  ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();


            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + "  " + passengerDistrict + " / " + passengerCity + " " + passengerAge);









            #endregion


            #region klavyeden tam sayı girişleri ve dönüşümler


            //ABC12D 

            //int shoesPrice, computerPrice, chariPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chariPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chariPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);




            #endregion


            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:  ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunuzu giriniz:  ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunuzu giriniz:  ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+ result);











            #endregion


            #region klavyeden karakter girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsyet: "+ gender);


            #endregion

            Console.Read();
        }
    }
}
