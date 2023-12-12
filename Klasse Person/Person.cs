using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Person
{
    internal class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }
        public int Højde { get; set; }
        public int Vægt { get; set; }

        public Person()
        {
        }

        public Person(string forNavn, string efterNavn)
        {
            ForNavn = forNavn;
            EfterNavn = efterNavn;
        }

        public Person(string forNavn, string efterNavn, int højde, int vægt)
        {
            ForNavn = forNavn;
            EfterNavn = efterNavn;
            Højde = højde;
            Vægt = vægt;
        }

        public override string ToString()
        {
            return $"First Name: {ForNavn}\nLast Name: {EfterNavn}\nHeight: {Højde}\nWeight: {Vægt}\nBMI: {GetBMI()}\n";
        }

        public float GetBMI()
        {
            return (Vægt / ((Højde / 100.0f) * (Højde / 100.0f)));
        }

        public string GetFullName()
        {
            return $"{ForNavn} {EfterNavn}";
        }

        public void SetFullName(string f, string e)
        {
            ForNavn = f;
            EfterNavn = e;
        }

        public void SetFullName(string s)
        {
            string[] words = s.Split(' ');

            if(words.Length == 1)
            {
                EfterNavn = words[0];
            }
            else
            {
                EfterNavn = words[words.Length - 1];
                ForNavn = string.Join(" ", words, 0, words.Length - 1);
            }
        }

        public int CompareTo(object obj)
        {
            return this.ForNavn.CompareTo(((Person)obj).ForNavn);
        }
    }
}
