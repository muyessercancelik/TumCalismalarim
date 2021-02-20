using System;

namespace OyunCalismamm
{
    class GamerUserManager :UserManager,IUserService
    {
        IUserDogrulamaService _userDogrulamaService;
        public GamerUserManager(IUserDogrulamaService userDogrulamaService)
        {
            _userDogrulamaService = userDogrulamaService;
        }




        public string UserName { get; set; }

        public void Add(GamerUserManager gamerUserManager)
        {
            if (_userDogrulamaService.DogrulamaYap(gamerUserManager)==true)
            {
                Console.WriteLine("Oyuncu Eklendi. ");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, ekleme yapılamadı. ");
            }
        }

        public void Delete(GamerUserManager gamerUserManager)
        {
            Console.WriteLine("Oyuncu Silindi. ");
        }

        public void Update(GamerUserManager gamerUserManager)
        {
            Console.WriteLine("Oyuncu Güncellendi. ");
        }
    }
}
