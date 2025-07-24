using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //    double number;

            //    number = 4.84;

            //    Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 15.44;
            //orangePrice =12.50;
            //strawberryPrice =30.33;
            //potatoPrice =12.22;
            //tomatoPrice =10.20;

            //Console.WriteLine("---- Elma Birim Fiyatı: "+ applePrice +"TL" );
            //Console.WriteLine("---- portakal Birim Fiyatı: "+ orangePrice +"TL");
            //Console.WriteLine("---- çilek Birim Fiyatı: "+ strawberryPrice+"TL");
            //Console.WriteLine("---- patates Birim Fiyatı: "+ potatoPrice+"TL");
            //Console.WriteLine("---- domates Birim Fiyatı: "+ tomatoPrice+"TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.690;
            //strawberryGram = 1.200;
            //potatoGram =1.400;
            //tomatoGram = 3.400;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice=strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram + potatoPrice;
            //double tomatoTotalPrice = tomatoGram + tomatoPrice;

            //Console.WriteLine("Alınan Ürün:Elma - " + "Birim Fiyat: " + applePrice + "- Gramaj: "
            //    + appleGram + "- Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün:Portakal - " + "Birim Fiyat: " + orangePrice + "- Gramaj: "
            //    + orangeGram + "- Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün:Çilek - " + "Birim Fiyat: " + strawberryPrice + "- Gramaj: "
            //    + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün:patates - " + "Birim Fiyat: " + potatoPrice + "- Gramaj: "
            //    + potatoGram + "- Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün:Domates - " + "Birim Fiyat: " + tomatoPrice + "- Gramaj: "
            //    + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice);

            //Double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice 
            //    + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " +shoppingTotalPrice+"TL");


            #endregion


            #region char değişkenler
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region klavyeden veri girişleri string değişkenler

            //Console.WriteLine("****CSharp Hava Yolları Yolcu Bİlgisi****");
            //Console.WriteLine();

            //string passengerNAme, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentyNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerNAme = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik: ");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu TC Kimlik No :  " + passengerIdentyNumber + "-Yolcu Adı Soyadı: "+ passengerNAme + ""+ passengerSurname +
            //    " "+ passengerDistrict +"/" + passengerCity + ""+ passengerAge );


            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşler 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 3000;
            //tvPrice = 5000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabın sayısını giriniz: ");
            //shoesCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısnı giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısnı griniz:  ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice+ computerCount*computerPrice + chairCount*chairPrice + tvPrice*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek miktar: " +totalPrice);


            #endregion

            #region Klavyeden ondalıklı sayı işlemleri

            //double exam1,exam2, exam3,result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+ result );




            #endregion

            #region Klavyeden karakter girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender=char.Parse (Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);



            #endregion

            Console.Read();
        }
    }
}
  