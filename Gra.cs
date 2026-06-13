using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class Gra : Produkt
    {
        public GatunekGry Gatunek { get; set; }

        public Platforma Platforma { get; set; }

        public int PEGI { get; set; }

        public Gra()
        {

        }

        public Gra(int id,
                   string nazwa,
                   decimal cena,
                   string producent,
                   int iloscNaStanie,
                   GatunekGry gatunek,
                   Platforma platforma,
                   int pegi)
            : base(id, nazwa, cena, producent, iloscNaStanie)
        {
            Gatunek = gatunek;
            Platforma = platforma;
            PEGI = pegi;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Gatunek: {Gatunek} | Platforma: {Platforma} | PEGI: {PEGI}";
        }
    }
}
