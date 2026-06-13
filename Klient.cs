using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class Klient
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Email { get; set; }

        public int PunktyLojalnosciowe { get; set; }

        public Klient()
        {

        }

        public Klient(string imie,
                      string nazwisko,
                      string email)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            PunktyLojalnosciowe = 0;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} | {Email} | Punkty: {PunktyLojalnosciowe}";
        }
    }
}
