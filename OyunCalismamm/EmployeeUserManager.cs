using System;

namespace OyunCalismamm
{
    class EmployeeUserManager :UserManager, IUserService
    {
        IUserDogrulamaService _userDogrulamaService;
        public EmployeeUserManager(IUserDogrulamaService userDogrulamaService)
        {
            _userDogrulamaService = userDogrulamaService;
        }

        public void Add(EmployeeUserManager employeeUserManager)
        {
            if (_userDogrulamaService.DogrulamaYap(employeeUserManager) == true)
            {
                Console.WriteLine("Oyuncu Eklendi. ");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, ekleme yapılamadı. ");
            }
        }



        public int PersonNumber { get; set; }

        public void Add(EmployeeUserManager employeeUserManager)
        {
            Console.WriteLine("Personel Eklendi. ");
        }

        public void Delete(EmployeeUserManager employeeUserManager)
        {
            Console.WriteLine("Personel Silindi. ");
        }

        public void Update(EmployeeUserManager employeeUserManager)
        {
            Console.WriteLine("Personel Güncellendi. ");
        }

       
    }
}
