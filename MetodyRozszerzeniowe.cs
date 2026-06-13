using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public static class MetodyRozszerzeniowe
    {
        public static void UzupelnijStan(this Produkt produkt, int ilosc)
        {
            produkt.IloscNaStanie += ilosc;
        }

        public static bool CzyJestDostepny(this Produkt produkt)
        {
            return produkt.IloscNaStanie > 0;
        }
    }
}
