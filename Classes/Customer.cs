using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {

        public int Id { get; set; }

        private string _firstName;
        public string FirstName 
        {
            get { return _firstName; }
            set {_firstName = value;}
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
    //public string FirstName; de aynı işi yapıyor get set ne gibi bir farklılık yaptı burada? Güncelleme kolaylığı sağlar.

}
