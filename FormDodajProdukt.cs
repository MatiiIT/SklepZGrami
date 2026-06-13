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
    public partial class FormDodajProdukt : Form
    {
        private List<Produkt> produkty;

        public Produkt NowyProdukt { get; private set; }

        public FormDodajProdukt(List<Produkt> produkty)
        {
            InitializeComponent();

            this.produkty = produkty;

            WypelnijComboBoxy();
            UstawWidocznoscPolDodawania();
        }

        private void WypelnijComboBoxy()
        {
            comboBoxDodajTyp.Items.Clear();
            comboBoxDodajTyp.Items.Add("Gra");
            comboBoxDodajTyp.Items.Add("DLC");
            comboBoxDodajTyp.Items.Add("Akcesoria");
            comboBoxDodajTyp.SelectedIndex = 0;

            comboBoxDodajGatunek.DataSource = Enum.GetValues(typeof(GatunekGry));
            comboBoxDodajPlatforma.DataSource = Enum.GetValues(typeof(Platforma));
        }

        private void UstawWidocznoscPolDodawania()
        {
            if (comboBoxDodajTyp.SelectedItem == null)
            {
                return;
            }

            string typ = comboBoxDodajTyp.SelectedItem.ToString();

            bool czyGra = typ == "Gra";
            bool czyDLC = typ == "DLC";
            bool czyAkcesoria = typ == "Akcesoria";

            labelDodajGatunek.Visible = czyGra;
            comboBoxDodajGatunek.Visible = czyGra;

            labelDodajPlatforma.Visible = czyGra;
            comboBoxDodajPlatforma.Visible = czyGra;

            labelDodajPEGI.Visible = czyGra;
            textBoxDodajPEGI.Visible = czyGra;

            labelDodajGraBazowa.Visible = czyDLC;
            textBoxDodajGraBazowa.Visible = czyDLC;

            labelDodajTypAkcesoriow.Visible = czyAkcesoria;
            textBoxDodajTypAkcesoriow.Visible = czyAkcesoria;

            int pozycjaPrzyciskow;

            if (czyGra)
            {
                labelDodajGatunek.Top = 216;
                comboBoxDodajGatunek.Top = 216;

                labelDodajPlatforma.Top = 254;
                comboBoxDodajPlatforma.Top = 254;

                labelDodajPEGI.Top = 293;
                textBoxDodajPEGI.Top = 293;

                pozycjaPrzyciskow = textBoxDodajPEGI.Bottom + 11;
            }
            else if (czyDLC)
            {
                labelDodajGraBazowa.Top = 216;
                textBoxDodajGraBazowa.Top = 216;

                pozycjaPrzyciskow = textBoxDodajGraBazowa.Bottom + 11;
            }
            else
            {
                labelDodajTypAkcesoriow.Top = 216;
                textBoxDodajTypAkcesoriow.Top = 216;

                pozycjaPrzyciskow = textBoxDodajTypAkcesoriow.Bottom + 11;
            }

            buttonAnulujDodawanie.Top = pozycjaPrzyciskow;
            buttonZapiszProdukty.Top = pozycjaPrzyciskow;

            groupBoxDodawanie.Height = buttonAnulujDodawanie.Bottom + 15;
            this.Height = groupBoxDodawanie.Bottom + 57;
        }

        private void WyczyscPolaDodawania()
        {
            textBoxDodajNazwa.Clear();
            textBoxDodajCena.Clear();
            textBoxDodajProducent.Clear();
            textBoxDodajStan.Clear();
            textBoxDodajPEGI.Clear();
            textBoxDodajGraBazowa.Clear();
            textBoxDodajTypAkcesoriow.Clear();

            comboBoxDodajTyp.SelectedIndex = 0;
        }

        private void comboBoxDodajTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UstawWidocznoscPolDodawania();
        }

        private void buttonZapiszProdukty_Click(object sender, EventArgs e)
        {
            string nazwa = textBoxDodajNazwa.Text;
            string producent = textBoxDodajProducent.Text;

            if (string.IsNullOrWhiteSpace(nazwa))
            {
                MessageBox.Show("Podaj nazwę produktu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(producent))
            {
                MessageBox.Show("Podaj producenta.");
                return;
            }

            if (!decimal.TryParse(textBoxDodajCena.Text, out decimal cena) || cena <= 0)
            {
                MessageBox.Show("Podaj poprawną cenę większą od 0.");
                return;
            }

            if (!int.TryParse(textBoxDodajStan.Text, out int stan) || stan < 0)
            {
                MessageBox.Show("Podaj poprawny stan magazynowy.");
                return;
            }

            int noweId;
            if (produkty.Count == 0)
            {
                noweId = 1;
            }
            else
            {
                noweId = produkty.Max(p => p.Id) + 1;
            }

            string typ = comboBoxDodajTyp.SelectedItem.ToString();

            if (typ == "Gra")
            {
                if (!int.TryParse(textBoxDodajPEGI.Text, out int pegi))
                {
                    MessageBox.Show("Podaj poprawne PEGI.");
                    return;
                }

                NowyProdukt = new Gra(
                    noweId,
                    nazwa,
                    cena,
                    producent,
                    stan,
                    (GatunekGry)comboBoxDodajGatunek.SelectedItem,
                    (Platforma)comboBoxDodajPlatforma.SelectedItem,
                    pegi);
            }
            else if (typ == "DLC")
            {
                if (string.IsNullOrWhiteSpace(textBoxDodajGraBazowa.Text))
                {
                    MessageBox.Show("Podaj nazwę gry bazowej dla DLC.");
                    return;
                }

                NowyProdukt = new DodatekDLC(
                    noweId,
                    nazwa,
                    cena,
                    producent,
                    stan,
                    textBoxDodajGraBazowa.Text);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxDodajTypAkcesoriow.Text))
                {
                    MessageBox.Show("Podaj typ akcesoriów.");
                    return;
                }

                NowyProdukt = new Akcesoria(
                    noweId,
                    nazwa,
                    cena,
                    producent,
                    stan,
                    textBoxDodajTypAkcesoriow.Text);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnulujDodawanie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
