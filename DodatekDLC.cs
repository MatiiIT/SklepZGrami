using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class DodatekDLC : Produkt
    {
        public string GraBazowa { get; set; }

        public DodatekDLC()
        {

        }

        public DodatekDLC(int id,
                          string nazwa,
                          decimal cena,
                          string producent,
                          int iloscNaStanie,
                          string graBazowa)
            : base(id, nazwa, cena, producent, iloscNaStanie)
        {
            GraBazowa = graBazowa;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Gra bazowa: {GraBazowa}";
        }
    }
}
