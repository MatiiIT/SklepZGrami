using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class Zamowienie
    {
        public int Id { get; set; }

        public Klient Klient { get; set; }

        public List<Produkt> Produkty { get; set; }

        public StatusZamowienia Status { get; set; }

        public Zamowienie()
        {
            Produkty = new List<Produkt>();
            Status = StatusZamowienia.Nowe;
        }

        public Zamowienie(int id, Klient klient)
        {
            Id = id;
            Klient = klient;
            Produkty = new List<Produkt>();
            Status = StatusZamowienia.Nowe;
        }

        public decimal ObliczWartosc()
        {
            return Produkty.Sum(p => p.Cena);
        }

        public override string ToString()
        {
            return $"Nr: {Id} | Klient: {Klient.Imie} {Klient.Nazwisko} | " + $"Wartość: {ObliczWartosc()} zł | Status: {Status}";
        }
    }
}
