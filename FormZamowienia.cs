using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SklepZGramiBiblioteka;

namespace SklepZGramiApp
{
    public partial class FormZamowienia : Form
    {
        private List<Zamowienie> zamowienia;
        public FormZamowienia(List<Zamowienie> zamowienia)
        {
            InitializeComponent();
            this.zamowienia = zamowienia;
            WczytajZamowienia();
        }

        private void WczytajZamowienia()
        {
            dataGridViewZamowienia.DataSource = null;
            dataGridViewZamowienia.DataSource = zamowienia;
        }

        private Zamowienie PobierzZaznaczoneZamowienie()
        {
            if (dataGridViewZamowienia.CurrentRow == null)
            {
                return null;
            }

            return dataGridViewZamowienia.CurrentRow.DataBoundItem as Zamowienie;
        }

        private void PokazSzczegolyZamowienia()
        {
            Zamowienie zamowienie = PobierzZaznaczoneZamowienie();

            if (zamowienie == null)
            {
                return;
            }

            labelSzczegolyZamowienia.Text =
            $"Nr zamówienia: {zamowienie.Id}\n" +
            $"Klient: {zamowienie.Klient.Imie} {zamowienie.Klient.Nazwisko}\n" +
            $"Status: {zamowienie.Status}\n" +
            $"Liczba produktów: {zamowienie.Produkty.Count}\n" +
            $"Wartość: {zamowienie.ObliczWartosc():0.00} zł";

            listBoxProduktyZamowienia.Items.Clear();

            var grupyProduktow = zamowienie.Produkty.GroupBy(p => p.Nazwa);

            foreach (var grupa in grupyProduktow)
            {
                listBoxProduktyZamowienia.Items.Add($"{grupa.Key} x{grupa.Count()} ({grupa.Sum(p => p.Cena):0.00} zł)");
            }
        }

        private void dataGridViewZamowienia_SelectionChanged(object sender, EventArgs e)
        {
            PokazSzczegolyZamowienia();
        }
    }
}
