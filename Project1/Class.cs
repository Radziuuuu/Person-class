using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {

    public class Osoba
    {

        private string imie;
        private string nazwisko;
        private char plec;
        private DateTime dataUrodzenia;


        //Konstruktor domyślny
        public Osoba(string imie, string nazwisko, char plec, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.dataUrodzenia = dataUrodzenia;
        }

        //get & set
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public char Plec
        {
            get { return plec; }
            set { plec = value; }
        }

        public DateTime DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; } 
        }
    }

}
