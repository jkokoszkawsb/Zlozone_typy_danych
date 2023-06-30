using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public enum Plec
    {
        m,
        k
    }

    public struct Student
    {
        public string Nazwisko;
        public int NumerAlbumu;
        public double Ocena;
        public Plec Plec;
    }
    internal class zad4
    {
        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            for (int i = 0; i < grupa.Length; i++)
            {
                Wypelnianie(ref grupa[i]);
            }

            foreach (Student student in grupa)
            {
                WyswietlanieInformacji(student);
            }

            double sredniaOcen = WyliczenieSredniejOcen(grupa);
            Console.WriteLine("Średnia ocen w grupie: " + sredniaOcen);
            Console.ReadKey();
        }
        public static void Wypelnianie(ref Student student)
        {
            Console.WriteLine("Podaj nazwisko studenta:");
            student.Nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj numer albumu studenta:");
            student.NumerAlbumu = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ocenę studenta (2.0 - 5.0):");
            student.Ocena = DodajOcene(double.Parse(Console.ReadLine()));

            Console.WriteLine("Podaj płeć studenta (m - Mężczyzna, k - Kobieta");
            if (Enum.TryParse(Console.ReadLine(), out Plec plec))
            {
                student.Plec = plec;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość. Ustawiono domyślną wartość: Mężczyzna");
                student.Plec = Plec.m;
            }
        }

        public static double DodajOcene(double ocena)
        {
            if (ocena < 2.0)
                return 2.0;
            else if (ocena > 5.0)
                return 5.0;
            else
                return ocena;
        }

        public static double WyliczenieSredniejOcen(Student[] grupa)
        {
            double suma = 0;

            foreach (Student student in grupa)
            {
                suma += student.Ocena;
            }

            return suma / grupa.Length;
        }

        public static void WyswietlanieInformacji(Student student)
        {
            Console.WriteLine("Nazwisko: " + student.Nazwisko + ", Numer albumu: " + student.NumerAlbumu +
                ", Ocena: " + student.Ocena + ", Płeć: " + student.Plec);
        }

    }
}
