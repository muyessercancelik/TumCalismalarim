using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Müyesser";

            var result = sentence.Length;//Cümlenin kaç karakter olduğunu verir.
            var result2 = sentence.Clone();//Cümlenin bir referansını oluşturur. Clonlamak için kullanılır.
            sentence = "My name is Mustafa";//Ben değeri değiştirsem de result2 yi değiştirememiş oluyorum, çünkü klonladım.

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");//Bir metin içinde ifade arandığında kullanılır.
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//Aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello, ");//Cümlenin 0. karakterinden itibaren Hello, ekler.
            var result9 = sentence.Substring(3);//Metni parçalamak için kullanılır.3. karaktere kadar olan kısmı keser.
            var result10 = sentence.Substring(3, 4);//3. karakterden itibaren toplam 4 karakteri getir sadece. name
            var result11 = sentence.ToLower();//Bütün karakterleri küçük harfe çevirmeye yarar.
            var result12 = sentence.ToUpper();//Bütün karakterleri büyük harfe çevirmeye yarar.
            var result13 = sentence.Replace(" ", "-");//Boşluk yerine çizgi ekler.
            var result14 = sentence.Remove(2);//2. karakterden sonrasını keser. Sadece My kalır.
            var result15 = sentence.Remove(2, 5);//2. karakterden sonra kaç karakter keseceğini belirtir.


            //Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        private static void Intro()
        {
            string city = "Ankara"; //Aslında string bir Char array dir.Ankara kelimesi 6, 6 elemanlı bir array oluşur.
            //Console.WriteLine(city[0]);//A yazar sadece

            foreach (var altalta in city)
            {
                Console.WriteLine(altalta);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Bu şekilde yazdığında bellekte 3. bir değişkene gerek kalmadı. result olmadan aynı işlemi yapmış olduk.
        }
    }
}
