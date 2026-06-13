using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class Akcesoria : Produkt
    {
        public string Typ { get; set; }

        public Akcesoria()
        {

        }

        public Akcesoria(int id,
                         string nazwa,
                         decimal cena,
                         string producent,
                         int iloscNaStanie,
                         string typ)
            : base(id, nazwa, cena, producent, iloscNaStanie)
        {
            Typ = typ;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Typ: {Typ}";
        }
    }
}
