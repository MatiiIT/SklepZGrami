using SklepZGramiBiblioteka;

namespace SklepZGramiApp
{
    public partial class Form1 : Form
    {
        private Sklep sklep;

        private List<Produkt> koszyk;
        public Form1()
        {
            InitializeComponent();

            sklep = new Sklep();
            koszyk = new List<Produkt>();

            DaneStartowe.Zaladuj(sklep);

            WczytajKlientow();
            WczytajProdukty();
            WypelnijComboBoxy();
            PodlaczZdarzenia();
            PokazSzczegolyProduktu();
        }

        private void WczytajProdukty()
        {
            dataGridViewProdukty.DataSource = null;
            dataGridViewProdukty.DataSource = sklep.Produkty;
        }

        private void PokazProdukty(List<Produkt> produkty)
        {
            dataGridViewProdukty.DataSource = null;
            dataGridViewProdukty.DataSource = produkty;
        }

        private List<Produkt> FiltrujProdukty()
        {
            List<Produkt> wyniki = sklep.Produkty.ToList();

            string typ = comboBoxTypFiltr.SelectedItem.ToString();

            if (typ == "Gra")
            {
                wyniki = wyniki.OfType<Gra>().Cast<Produkt>().ToList();
            }
            else if (typ == "DLC")
            {
                wyniki = wyniki.OfType<DodatekDLC>().Cast<Produkt>().ToList();
            }
            else if (typ == "Akcesoria")
            {
                wyniki = wyniki.OfType<Akcesoria>().Cast<Produkt>().ToList();
            }

            if (comboBoxGatunekFiltr.SelectedItem is GatunekGry gatunek)
            {
                wyniki = wyniki
                    .OfType<Gra>()
                    .Where(g => g.Gatunek == gatunek)
                    .Cast<Produkt>()
                    .ToList();
            }

            if (comboBoxPlatformaFiltr.SelectedItem is Platforma platforma)
            {
                wyniki = wyniki
                    .OfType<Gra>()
                    .Where(g => g.Platforma == platforma)
                    .Cast<Produkt>()
                    .ToList();
            }

            return wyniki;
        }

        private void WczytajKlientow()
        {
            comboBoxKlienci.DataSource = sklep.Klienci;
        }

        private Produkt PobierzZaznaczonyProdukt()
        {
            if (dataGridViewProdukty.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow wiersz = dataGridViewProdukty.SelectedRows[0];

            if (wiersz.DataBoundItem == null)
            {
                return null;
            }

            return wiersz.DataBoundItem as Produkt;
        }

        private void PokazSzczegolyProduktu()
        {
            Produkt produkt = PobierzZaznaczonyProdukt();

            if (produkt == null)
            {
                return;
            }

            labelSzczegolyNazwa.Text = $"Nazwa: {produkt.Nazwa}";
            labelSzczegolyCena.Text = $"Cena: {produkt.Cena} z³";
            labelSzczegolyProducent.Text = $"Producent: {produkt.Producent}";
            labelSzczegolyStan.Text = $"Stan: {produkt.IloscNaStanie}";

            if (produkt is Gra gra)
            {
                labelSzczegolyTyp.Text = "Typ: Gra";
                labelSzczegolyDodatkowe.Text =
                    $"Gatunek: {gra.Gatunek}, Platforma: {gra.Platforma}, PEGI: {gra.PEGI}";
            }
            else if (produkt is DodatekDLC dlc)
            {
                labelSzczegolyTyp.Text = "Typ: Dodatek DLC";
                labelSzczegolyDodatkowe.Text = $"Gra bazowa: {dlc.GraBazowa}";
            }
            else if (produkt is Akcesoria akcesoria)
            {
                labelSzczegolyTyp.Text = "Typ: Akcesoria";
                labelSzczegolyDodatkowe.Text = $"Typ akcesoriów: {akcesoria.Typ}";
            }
        }

        private void WypelnijComboBoxy()
        {
            comboBoxTypFiltr.Items.Clear();
            comboBoxTypFiltr.Items.Add("Wszystkie");
            comboBoxTypFiltr.Items.Add("Gra");
            comboBoxTypFiltr.Items.Add("DLC");
            comboBoxTypFiltr.Items.Add("Akcesoria");
            comboBoxTypFiltr.SelectedIndex = 0;

            comboBoxGatunekFiltr.Items.Clear();
            comboBoxGatunekFiltr.Items.Add("Wszystkie");

            foreach (GatunekGry gatunek in Enum.GetValues(typeof(GatunekGry)))
            {
                comboBoxGatunekFiltr.Items.Add(gatunek);
            }

            comboBoxGatunekFiltr.SelectedIndex = 0;

            comboBoxPlatformaFiltr.Items.Clear();
            comboBoxPlatformaFiltr.Items.Add("Wszystkie");

            foreach (Platforma platforma in Enum.GetValues(typeof(Platforma)))
            {
                comboBoxPlatformaFiltr.Items.Add(platforma);
            }

            comboBoxPlatformaFiltr.SelectedIndex = 0;
        }

        private void PodlaczZdarzenia()
        {
            sklep.OnProduktDodany += ProduktDodany;
            sklep.OnProduktSprzedany += ProduktSprzedany;
            sklep.OnZamowienieUtworzone += ZamowienieUtworzone;
        }

        private void PokazSukces(string komunikat)
        {
            labelStatus.ForeColor = Color.DarkGreen;
            labelStatus.Text = komunikat;
        }

        private void PokazBlad(string komunikat)
        {
            labelStatus.ForeColor = Color.Red;
            labelStatus.Text = komunikat;
        }

        private void ProduktDodany(Produkt produkt)
        {
            PokazSukces($"Dodano produkt: {produkt.Nazwa}");
        }

        private void ProduktSprzedany(Produkt produkt)
        {
            PokazSukces($"Sprzedano produkt: {produkt.Nazwa}");
        }

        private void ZamowienieUtworzone(Zamowienie zamowienie)
        {
            PokazSukces($"Utworzono zamówienie nr {zamowienie.Id}");
        }

        private void dataGridViewProdukty_SelectionChanged(object sender, EventArgs e)
        {
            PokazSzczegolyProduktu();
        }

        private void buttonDodajDoKoszyka_Click(object sender, EventArgs e)
        {
            Produkt produkt = PobierzZaznaczonyProdukt();

            if (produkt == null)
            {
                PokazBlad("Nie wybrano produktu.");
                return;
            }

            if (!produkt.CzyJestDostepny())
            {
                PokazBlad($"Brak produktu na stanie: {produkt.Nazwa}");
                return;
            }

            produkt.IloscNaStanie--;

            koszyk.Add(produkt);

            OdswiezKoszyk();
            WczytajProdukty();
            PokazSzczegolyProduktu();

            PokazSukces($"Dodano do koszyka: {produkt.Nazwa}");
        }
        private void OdswiezKoszyk()
        {
            listBoxKoszyk.DataSource = null;
            listBoxKoszyk.DataSource = koszyk;

            decimal suma = koszyk.Sum(p => p.Cena);

            labelSumaKoszyka.Text = $"Suma: {suma} z³";
        }

        private void buttonUsunZKoszyka_Click(object sender, EventArgs e)
        {
            Produkt produkt = listBoxKoszyk.SelectedItem as Produkt;

            if (produkt == null)
            {
                PokazBlad("Nie wybrano produktu z koszyka.");
                return;
            }

            produkt.UzupelnijStan(1);

            koszyk.Remove(produkt);

            OdswiezKoszyk();
            WczytajProdukty();
            PokazSzczegolyProduktu();

            PokazSukces($"Usuniêto z koszyka: {produkt.Nazwa}");
        }

        private void buttonWyczyscKoszyk_Click(object sender, EventArgs e)
        {
            foreach (Produkt produkt in koszyk)
            {
                produkt.UzupelnijStan(1);
            }

            koszyk.Clear();

            OdswiezKoszyk();
            WczytajProdukty();
            PokazSzczegolyProduktu();

            PokazSukces("Koszyk zosta³ wyczyszczony.");
        }

        private void buttonZlozZamowienie_Click(object sender, EventArgs e)
        {
            try
            {
                Klient klient = comboBoxKlienci.SelectedItem as Klient;

                Zamowienie zamowienie = sklep.ZlozZamowienie(klient, koszyk);

                OdswiezComboBoxKlientow(klient);

                koszyk.Clear();

                OdswiezKoszyk();
                WczytajProdukty();
                PokazSzczegolyProduktu();

                PokazSukces($"Z³o¿ono zamówienie nr {zamowienie.Id} o wartoœci {zamowienie.ObliczWartosc():0.00} z³.");
            }
            catch (BrakTowaruException ex)
            {
                PokazBlad(ex.Message);
            }
        }

        private void OdswiezComboBoxKlientow(Klient wybranyKlient)
        {
            comboBoxKlienci.DataSource = null;
            comboBoxKlienci.DataSource = sklep.Klienci;

            comboBoxKlienci.SelectedItem = wybranyKlient;
        }

        private void buttonSzukajNazwa_Click(object sender, EventArgs e)
        {
            string nazwa = textBoxSzukajNazwa.Text;

            if (string.IsNullOrWhiteSpace(nazwa))
            {
                PokazBlad("Podaj nazwê produktu.");
                return;
            }

            List<Produkt> wyniki = sklep.ZnajdzProduktyPoNazwie(nazwa);
            PokazProdukty(wyniki);

            PokazSukces($"Wyszukiwanie zakoñczone. Znaleziono: {wyniki.Count}");
        }

        private void buttonSzukajCena_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxCenaOd.Text, out decimal cenaOd))
            {
                PokazBlad("Podaj poprawn¹ cenê od.");
                return;
            }

            if (!decimal.TryParse(textBoxCenaDo.Text, out decimal cenaDo))
            {
                PokazBlad("Podaj poprawn¹ cenê do.");
                return;
            }

            if (cenaOd > cenaDo)
            {
                PokazBlad("Cena od nie mo¿e byæ wiêksza ni¿ cena do.");
                return;
            }

            List<Produkt> wyniki = sklep.ZnajdzProduktyWCenieOdDo(cenaOd, cenaDo);

            PokazProdukty(wyniki);
            PokazSukces($"Wyszukiwanie zakoñczone. Znaleziono: {wyniki.Count}");
        }

        private void buttonPokazWszystkie_Click(object sender, EventArgs e)
        {
            textBoxSzukajNazwa.Clear();
            textBoxCenaOd.Clear();
            textBoxCenaDo.Clear();

            WczytajProdukty();

            PokazSukces("Wyœwietlono wszystkie produkty.");
        }

        private void buttonSortujCenaRosnaco_Click(object sender, EventArgs e)
        {
            PokazProdukty(sklep.ProduktyPosortowanePoCenieRosnaco());
            PokazSukces("Posortowano produkty po cenie rosn¹co.");
        }

        private void buttonSortujCenaMalejaco_Click(object sender, EventArgs e)
        {
            PokazProdukty(sklep.ProduktyPosortowanePoCenieMalejaco());
            PokazSukces("Posortowano produkty po cenie malej¹co.");
        }

        private void buttonFiltruj_Click(object sender, EventArgs e)
        {
            List<Produkt> wyniki = FiltrujProdukty();

            PokazProdukty(wyniki);
            PokazSukces($"Przefiltrowano produkty. Znaleziono: {wyniki.Count}");
        }

        private void buttonPokazDodawanie_Click(object sender, EventArgs e)
        {
            FormDodajProdukt formDodajProdukt = new FormDodajProdukt(sklep.Produkty);

            if (formDodajProdukt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sklep.DodajProdukt(formDodajProdukt.NowyProdukt);

                    WczytajProdukty();

                    PokazSukces($"Dodano produkt: {formDodajProdukt.NowyProdukt.Nazwa}");
                }
                catch (ProduktJuzIstniejeException ex)
                {
                    PokazBlad(ex.Message);
                }
            }
        }

        private void buttonHistoriaZamowien_Click(object sender, EventArgs e)
        {
            FormZamowienia formZamowienia = new FormZamowienia(sklep.Zamowienia);
            formZamowienia.ShowDialog();
        }

        private void buttonUsunProdukt_Click(object sender, EventArgs e)
        {
            Produkt produkt = PobierzZaznaczonyProdukt();

            if (produkt == null)
            {
                PokazBlad("Nie wybrano produktu do usuniêcia.");
                return;
            }

            DialogResult wynik = MessageBox.Show(
                $"Czy na pewno usun¹æ produkt: {produkt.Nazwa}?",
                "Potwierdzenie usuniêcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (wynik != DialogResult.Yes)
            {
                return;
            }

            sklep.Produkty.Remove(produkt);

            koszyk.RemoveAll(p => p.Id == produkt.Id);

            WczytajProdukty();

            if (dataGridViewProdukty.Rows.Count > 0)
            {
                dataGridViewProdukty.ClearSelection();
                dataGridViewProdukty.Rows[0].Selected = true;
            }

            OdswiezKoszyk();
            PokazSzczegolyProduktu();
            PokazSukces($"Usuniêto produkt: {produkt.Nazwa}");
        }
    }
}
