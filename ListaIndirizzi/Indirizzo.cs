using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {
        //ATTRIBUTI
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;
        //STATO
        //COSTRUTTORI
        public Indirizzo()
        {

        }

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }
        //GETTER
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getStreet()
        {
            return street;
        }
        public string getCity()
        {
            return city;
        }
        public string getProvince()
        {
            return province;
        }
        public string getZip()
        {
            return zip;
        }
        //SETTER
        //METODI
        public override string ToString()
        {
            string obj = name + ", " + surname + ", " + street + ", "  + city + ", " + province + ", " + zip;
            return obj;
        }
    }
}
