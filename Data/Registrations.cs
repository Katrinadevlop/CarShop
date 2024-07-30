using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarShopWpf
{
    class Registrations
    {
        [Key]
        public int id_person { get; set; }

        private string name, surname, patronymic, number_prone, city, password;

        public string Name
        {
            get { return name; }
            set { name = value; ; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string Number_prone
        {
            get { return number_prone; }
            set { number_prone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Registrations() { }

        public Registrations(string name, string surname, string patronymic, string number_phone, string city, string password)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.number_prone = number_phone;
            this.city = city;
            this.password = password;
        }
    }
}
