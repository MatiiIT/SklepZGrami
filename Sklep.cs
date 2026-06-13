using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public class Sklep
    {
        private List<Produkt> produkty;
        private List<Klient> klienci;
        private List<Zamowienie> zamowienia;

        public event ProduktZdarzenie OnProduktDodany;

        public event ProduktZdarzenie OnProduktSprzedany;

        public event ZamowienieZdarzenie OnZamowienieUtworzone;

        public Sklep()
        {
            produkty = new List<Produkt>();
            klienci = new List<Klient>();
            zamowienia = new List<Zamowienie>();
        }

        public List<Produkt> Produkty
        {
            get { return produkty; }
        }

        public List<Klient> Klienci
        {
            get { return klienci; }
        }

        public List<Zamowienie> Zamowienia
        {
            get { return zamowienia; }
        }

        public void DodajProdukt(Produkt produkt)
        {
            if (produkty.Any(p => p.Id == produkt.Id))
            {
                throw new ProduktJuzIstniejeException("Produkt o takim ID już istnieje.");
            }
            produkty.Add(produkt);
            OnProduktDodany?.Invoke(produkt);
        }

        public void DodajKlienta(Klient klient)
        {
            klienci.Add(klient);
        }

        public Produkt ZnajdzProduktPoId(int id)
        {
            return produkty.FirstOrDefault(p => p.Id == id);
        }

        public List<Produkt> ZnajdzProduktyPoNazwie(string nazwa)
        {
            return produkty
                .Where(p => p.Nazwa.ToLower().Contains(nazwa.ToLower()))
                .ToList();
        }

        public List<Produkt> ZnajdzProduktyWCenieOdDo(decimal cenaOd, decimal cenaDo)
        {
            return produkty
                .Where(p => p.Cena >= cenaOd && p.Cena <= cenaDo)
                .OrderBy(p => p.Cena)
                .ToList();
        }

        public List<Produkt> ProduktyPosortowanePoCenie()
        {
            return produkty
                .OrderBy(p => p.Cena)
                .ToList();
        }

        public List<Produkt> ProduktyPosortowanePoCenieRosnaco()
        {
            return produkty
                .OrderBy(p => p.Cena)
                .ToList();
        }

        public List<Produkt> ProduktyPosortowanePoCenieMalejaco()
        {
            return produkty
                .OrderByDescending(p => p.Cena)
                .ToList();
        }

        public List<Produkt> ProduktyZNiskimStanem(int granica)
        {
            return produkty
                .Where(p => p.IloscNaStanie <= granica)
                .ToList();
        }

        public List<Gra> GryNaPlatforme(Platforma platforma)
        {
            return produkty
                .OfType<Gra>()
                .Where(g => g.Platforma == platforma)
                .ToList();
        }

        public List<Gra> GryZGatunku(GatunekGry gatunek)
        {
            return produkty
                .OfType<Gra>()
                .Where(g => g.Gatunek == gatunek)
                .ToList();
        }

        public decimal ObliczWartoscMagazynu()
        {
            return produkty.Sum(p => p.WartoscMagazynowa());
        }

        public Zamowienie SprzedajProdukt(int idProduktu, Klient klient)
        {
            Produkt produkt = ZnajdzProduktPoId(idProduktu);

            if (produkt == null)
            {
                throw new BrakTowaruException("Nie znaleziono produktu.");
            }

            if (produkt.IloscNaStanie <= 0)
            {
                throw new BrakTowaruException("Brak produktu na stanie.");
            }

            produkt.Sprzedaj();

            klient.PunktyLojalnosciowe += 10;

            Zamowienie zamowienie = new Zamowienie(zamowienia.Count + 1, klient);
            zamowienie.Produkty.Add(produkt);
            zamowienie.Status = StatusZamowienia.Zrealizowane;

            zamowienia.Add(zamowienie);

            OnProduktSprzedany?.Invoke(produkt);
            OnZamowienieUtworzone?.Invoke(zamowienie);

            return zamowienie;
        }

        public Zamowienie ZlozZamowienie(Klient klient, List<Produkt> produktyZKoszyka)
        {
            if (klient == null)
            {
                throw new BrakTowaruException("Nie wybrano klienta.");
            }

            if (produktyZKoszyka.Count == 0)
            {
                throw new BrakTowaruException("Koszyk jest pusty.");
            }

            Zamowienie zamowienie = new Zamowienie(zamowienia.Count + 1, klient);

            foreach (Produkt produkt in produktyZKoszyka)
            {
                zamowienie.Produkty.Add(produkt);
                OnProduktSprzedany?.Invoke(produkt);
            }

            klient.PunktyLojalnosciowe += produktyZKoszyka.Count * 10;

            zamowienie.Status = StatusZamowienia.Zrealizowane;
            zamowienia.Add(zamowienie);

            OnZamowienieUtworzone?.Invoke(zamowienie);
            return zamowienie;
        }

        public override string ToString()
        {
            return $"Produkty: {produkty.Count}, Klienci: {klienci.Count}, Zamówienia: {zamowienia.Count}";
        }
    }
}
