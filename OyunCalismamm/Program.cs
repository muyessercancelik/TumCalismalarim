using System;

namespace OyunCalismamm
{
    class Program
    {
        static void Main(string[] args)
        {
            UserProjectService userProjectService = new UserProjectService();
            userProjectService.Add(new GamerUserManager(new UserDogrulamaManager()));
            GamerUserManager gamerUserManager1 = new GamerUserManager(new  UserDogrulamaManager());

            gamerUserManager1.FirstName = "Ahmet";
            gamerUserManager1.Id = 1;
            gamerUserManager1.LastName = "Cançelik";
            gamerUserManager1.TcNo = "123456789";
            gamerUserManager1.UserName = "ahmetcan";
            gamerUserManager1.BirthDay ="1991";

            //IUserDogrulamaService UserDogrulamaManager = new UserDogrulamaManager();
            //UserDogrulamaManager.TcNo = "123456789";
            //UserDogrulamaManager.BirthDay = "1991";


            //if (gamerUserManager1.BirthDay==UserDogrulamaManager.BirthDay && gamerUserManager1.TcNo==UserDogrulamaManager.TcNo)
            //{
            //    Console.WriteLine("Kullanıcı doğrulama işlemi başarılı. ");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı doğrulama işlemi başarısız. Tekrar deneyiniz. ");
            //}
            
        }
    }
}
