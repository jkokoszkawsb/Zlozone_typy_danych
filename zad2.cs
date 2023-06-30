using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    struct Student
    {
        public string imię;
        public string nazwisko;
        public int wiek;
        public int numerAlbumu;
        public string kierunek;
        public int semester;
    }
    struct Przedmiot
    {
        public string nazwa;
        public string kierunek;
        public int numerSemestru;
        public int ECTS;
    }
    struct NauczycielAkademicki
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public string tytul;
        public string przedmiot;
        public string katedra;
    }

    internal class zad2
    {
    
        static void Main(string[] args)
        {
        }
    }
}
