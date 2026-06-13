using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public abstract class Produkt : ISprzedawalny, IPromocyjny
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public decimal Cena { get; set; }

        public string Producent { get; set; }

        public int IloscNaStanie { get; set; }

        public Produkt()
        {

        }

        public Produkt(int id,
                       string nazwa,
                       decimal cena,
                       string producent,
                       int iloscNaStanie)
        {
            Id = id;
            Nazwa = nazwa;
            Cena = cena;
            Producent = producent;
            IloscNaStanie = iloscNaStanie;
        }

        public virtual void Sprzedaj()
        {
            if (IloscNaStanie > 0)
            {
                IloscNaStanie--;
            }
        }
        public virtual void UstawPromocje(decimal procent)
        {
            Cena -= Cena * procent / 100;
        }

        public virtual decimal WartoscMagazynowa()
        {
            return Cena * IloscNaStanie;
        }

        public override string ToString()
        {
            return $"{Id} | {Nazwa} | {Cena} zł | Stan: {IloscNaStanie}";
        }
    }
}
