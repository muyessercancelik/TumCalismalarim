using System;
namespace OyunCalismamm
{
    interface IUserDogrulamaService
    {
        bool DogrulamaYap(GamerUserManager gamerUserManager);
    }

    class UserDogrulamaManager : IUserDogrulamaService
    {
        public bool DogrulamaYap(GamerUserManager gamerUserManager)
        {
            if (gamerUserManager.TcNo=="123456789" && gamerUserManager.BirthDay=="1991" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
