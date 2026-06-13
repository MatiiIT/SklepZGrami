namespace SklepZGramiApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelGora = new Panel();
            buttonSortujCenaMalejaco = new Button();
            buttonSortujCenaRosnaco = new Button();
            buttonPokazWszystkie = new Button();
            buttonFiltruj = new Button();
            comboBoxPlatformaFiltr = new ComboBox();
            labelPlatformaFiltr = new Label();
            comboBoxGatunekFiltr = new ComboBox();
            labelGatunekFiltr = new Label();
            comboBoxTypFiltr = new ComboBox();
            labelTypFiltr = new Label();
            buttonSzukajCena = new Button();
            textBoxCenaDo = new TextBox();
            labelCenaDo = new Label();
            textBoxCenaOd = new TextBox();
            labelCenaOd = new Label();
            buttonSzukajNazwa = new Button();
            textBoxSzukajNazwa = new TextBox();
            labelSzukajNazwa = new Label();
            labelStatus = new Label();
            buttonHistoriaZamowien = new Button();
            comboBoxKlienci = new ComboBox();
            labelKlient = new Label();
            panelGlowny = new Panel();
            buttonPokazDodawanie = new Button();
            buttonDodajDoKoszyka = new Button();
            groupBoxKoszyk = new GroupBox();
            buttonZlozZamowienie = new Button();
            buttonWyczyscKoszyk = new Button();
            buttonUsunZKoszyka = new Button();
            labelSumaKoszyka = new Label();
            listBoxKoszyk = new ListBox();
            groupBoxSzczegoly = new GroupBox();
            labelSzczegolyDodatkowe = new Label();
            labelSzczegolyTyp = new Label();
            labelSzczegolyStan = new Label();
            labelSzczegolyProducent = new Label();
            labelSzczegolyCena = new Label();
            labelSzczegolyNazwa = new Label();
            labelProdukty = new Label();
            dataGridViewProdukty = new DataGridView();
            buttonUsunProdukt = new Button();
            panelGora.SuspendLayout();
            panelGlowny.SuspendLayout();
            groupBoxKoszyk.SuspendLayout();
            groupBoxSzczegoly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).BeginInit();
            SuspendLayout();
            // 
            // panelGora
            // 
            panelGora.Controls.Add(buttonSortujCenaMalejaco);
            panelGora.Controls.Add(buttonSortujCenaRosnaco);
            panelGora.Controls.Add(buttonPokazWszystkie);
            panelGora.Controls.Add(buttonFiltruj);
            panelGora.Controls.Add(comboBoxPlatformaFiltr);
            panelGora.Controls.Add(labelPlatformaFiltr);
            panelGora.Controls.Add(comboBoxGatunekFiltr);
            panelGora.Controls.Add(labelGatunekFiltr);
            panelGora.Controls.Add(comboBoxTypFiltr);
            panelGora.Controls.Add(labelTypFiltr);
            panelGora.Controls.Add(buttonSzukajCena);
            panelGora.Controls.Add(textBoxCenaDo);
            panelGora.Controls.Add(labelCenaDo);
            panelGora.Controls.Add(textBoxCenaOd);
            panelGora.Controls.Add(labelCenaOd);
            panelGora.Controls.Add(buttonSzukajNazwa);
            panelGora.Controls.Add(textBoxSzukajNazwa);
            panelGora.Controls.Add(labelSzukajNazwa);
            panelGora.Controls.Add(labelStatus);
            panelGora.Controls.Add(buttonHistoriaZamowien);
            panelGora.Controls.Add(comboBoxKlienci);
            panelGora.Controls.Add(labelKlient);
            panelGora.Dock = DockStyle.Top;
            panelGora.Location = new Point(0, 0);
            panelGora.Name = "panelGora";
            panelGora.Size = new Size(1546, 176);
            panelGora.TabIndex = 0;
            // 
            // buttonSortujCenaMalejaco
            // 
            buttonSortujCenaMalejaco.Location = new Point(389, 139);
            buttonSortujCenaMalejaco.Name = "buttonSortujCenaMalejaco";
            buttonSortujCenaMalejaco.Size = new Size(76, 30);
            buttonSortujCenaMalejaco.TabIndex = 21;
            buttonSortujCenaMalejaco.Text = "Cena ↓";
            buttonSortujCenaMalejaco.UseVisualStyleBackColor = true;
            buttonSortujCenaMalejaco.Click += buttonSortujCenaMalejaco_Click;
            // 
            // buttonSortujCenaRosnaco
            // 
            buttonSortujCenaRosnaco.Location = new Point(302, 139);
            buttonSortujCenaRosnaco.Name = "buttonSortujCenaRosnaco";
            buttonSortujCenaRosnaco.Size = new Size(76, 30);
            buttonSortujCenaRosnaco.TabIndex = 20;
            buttonSortujCenaRosnaco.Text = "Cena ↑";
            buttonSortujCenaRosnaco.UseVisualStyleBackColor = true;
            buttonSortujCenaRosnaco.Click += buttonSortujCenaRosnaco_Click;
            // 
            // buttonPokazWszystkie
            // 
            buttonPokazWszystkie.Location = new Point(69, 139);
            buttonPokazWszystkie.Name = "buttonPokazWszystkie";
            buttonPokazWszystkie.Size = new Size(135, 30);
            buttonPokazWszystkie.TabIndex = 19;
            buttonPokazWszystkie.Text = "Pokaż wszystkie";
            buttonPokazWszystkie.UseVisualStyleBackColor = true;
            buttonPokazWszystkie.Click += buttonPokazWszystkie_Click;
            // 
            // buttonFiltruj
            // 
            buttonFiltruj.AutoSize = true;
            buttonFiltruj.Location = new Point(215, 139);
            buttonFiltruj.Name = "buttonFiltruj";
            buttonFiltruj.Size = new Size(76, 30);
            buttonFiltruj.TabIndex = 18;
            buttonFiltruj.Text = "Filtruj";
            buttonFiltruj.UseVisualStyleBackColor = true;
            buttonFiltruj.Click += buttonFiltruj_Click;
            // 
            // comboBoxPlatformaFiltr
            // 
            comboBoxPlatformaFiltr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlatformaFiltr.FormattingEnabled = true;
            comboBoxPlatformaFiltr.Location = new Point(528, 95);
            comboBoxPlatformaFiltr.Name = "comboBoxPlatformaFiltr";
            comboBoxPlatformaFiltr.Size = new Size(135, 28);
            comboBoxPlatformaFiltr.TabIndex = 17;
            // 
            // labelPlatformaFiltr
            // 
            labelPlatformaFiltr.AutoSize = true;
            labelPlatformaFiltr.Location = new Point(445, 99);
            labelPlatformaFiltr.Name = "labelPlatformaFiltr";
            labelPlatformaFiltr.Size = new Size(77, 20);
            labelPlatformaFiltr.TabIndex = 16;
            labelPlatformaFiltr.Text = "Platforma:";
            // 
            // comboBoxGatunekFiltr
            // 
            comboBoxGatunekFiltr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGatunekFiltr.FormattingEnabled = true;
            comboBoxGatunekFiltr.Location = new Point(292, 95);
            comboBoxGatunekFiltr.Name = "comboBoxGatunekFiltr";
            comboBoxGatunekFiltr.Size = new Size(135, 28);
            comboBoxGatunekFiltr.TabIndex = 15;
            // 
            // labelGatunekFiltr
            // 
            labelGatunekFiltr.AutoSize = true;
            labelGatunekFiltr.Location = new Point(220, 99);
            labelGatunekFiltr.Name = "labelGatunekFiltr";
            labelGatunekFiltr.Size = new Size(66, 20);
            labelGatunekFiltr.TabIndex = 14;
            labelGatunekFiltr.Text = "Gatunek:";
            // 
            // comboBoxTypFiltr
            // 
            comboBoxTypFiltr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypFiltr.FormattingEnabled = true;
            comboBoxTypFiltr.Location = new Point(69, 95);
            comboBoxTypFiltr.Name = "comboBoxTypFiltr";
            comboBoxTypFiltr.Size = new Size(135, 28);
            comboBoxTypFiltr.TabIndex = 13;
            // 
            // labelTypFiltr
            // 
            labelTypFiltr.AutoSize = true;
            labelTypFiltr.Location = new Point(28, 99);
            labelTypFiltr.Name = "labelTypFiltr";
            labelTypFiltr.Size = new Size(35, 20);
            labelTypFiltr.TabIndex = 12;
            labelTypFiltr.Text = "Typ:";
            // 
            // buttonSzukajCena
            // 
            buttonSzukajCena.Location = new Point(1032, 52);
            buttonSzukajCena.Name = "buttonSzukajCena";
            buttonSzukajCena.Size = new Size(125, 29);
            buttonSzukajCena.TabIndex = 11;
            buttonSzukajCena.Text = "Szukaj po cenie";
            buttonSzukajCena.UseVisualStyleBackColor = true;
            buttonSzukajCena.Click += buttonSzukajCena_Click;
            // 
            // textBoxCenaDo
            // 
            textBoxCenaDo.Location = new Point(915, 53);
            textBoxCenaDo.Name = "textBoxCenaDo";
            textBoxCenaDo.Size = new Size(100, 27);
            textBoxCenaDo.TabIndex = 10;
            // 
            // labelCenaDo
            // 
            labelCenaDo.AutoSize = true;
            labelCenaDo.Location = new Point(879, 56);
            labelCenaDo.Name = "labelCenaDo";
            labelCenaDo.Size = new Size(30, 20);
            labelCenaDo.TabIndex = 9;
            labelCenaDo.Text = "do:";
            // 
            // textBoxCenaOd
            // 
            textBoxCenaOd.Location = new Point(760, 53);
            textBoxCenaOd.Name = "textBoxCenaOd";
            textBoxCenaOd.Size = new Size(100, 27);
            textBoxCenaOd.TabIndex = 8;
            // 
            // labelCenaOd
            // 
            labelCenaOd.AutoSize = true;
            labelCenaOd.Location = new Point(687, 56);
            labelCenaOd.Name = "labelCenaOd";
            labelCenaOd.Size = new Size(67, 20);
            labelCenaOd.TabIndex = 7;
            labelCenaOd.Text = "Cena od:";
            // 
            // buttonSzukajNazwa
            // 
            buttonSzukajNazwa.Location = new Point(479, 52);
            buttonSzukajNazwa.Name = "buttonSzukajNazwa";
            buttonSzukajNazwa.Size = new Size(76, 29);
            buttonSzukajNazwa.TabIndex = 6;
            buttonSzukajNazwa.Text = "Szukaj";
            buttonSzukajNazwa.UseVisualStyleBackColor = true;
            buttonSzukajNazwa.Click += buttonSzukajNazwa_Click;
            // 
            // textBoxSzukajNazwa
            // 
            textBoxSzukajNazwa.Location = new Point(70, 53);
            textBoxSzukajNazwa.Name = "textBoxSzukajNazwa";
            textBoxSzukajNazwa.Size = new Size(396, 27);
            textBoxSzukajNazwa.TabIndex = 5;
            // 
            // labelSzukajNazwa
            // 
            labelSzukajNazwa.AutoSize = true;
            labelSzukajNazwa.Location = new Point(10, 56);
            labelSzukajNazwa.Name = "labelSzukajNazwa";
            labelSzukajNazwa.Size = new Size(57, 20);
            labelSzukajNazwa.TabIndex = 4;
            labelSzukajNazwa.Text = "Nazwa:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(687, 14);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(61, 20);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Gotowe";
            // 
            // buttonHistoriaZamowien
            // 
            buttonHistoriaZamowien.Location = new Point(479, 9);
            buttonHistoriaZamowien.Name = "buttonHistoriaZamowien";
            buttonHistoriaZamowien.Size = new Size(184, 30);
            buttonHistoriaZamowien.TabIndex = 2;
            buttonHistoriaZamowien.Text = "Historia zamówień";
            buttonHistoriaZamowien.UseVisualStyleBackColor = true;
            buttonHistoriaZamowien.Click += buttonHistoriaZamowien_Click;
            // 
            // comboBoxKlienci
            // 
            comboBoxKlienci.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKlienci.FormattingEnabled = true;
            comboBoxKlienci.Location = new Point(70, 10);
            comboBoxKlienci.Name = "comboBoxKlienci";
            comboBoxKlienci.Size = new Size(396, 28);
            comboBoxKlienci.TabIndex = 1;
            // 
            // labelKlient
            // 
            labelKlient.AutoSize = true;
            labelKlient.Location = new Point(10, 14);
            labelKlient.Name = "labelKlient";
            labelKlient.Size = new Size(47, 20);
            labelKlient.TabIndex = 0;
            labelKlient.Text = "Klient";
            // 
            // panelGlowny
            // 
            panelGlowny.Controls.Add(buttonUsunProdukt);
            panelGlowny.Controls.Add(buttonPokazDodawanie);
            panelGlowny.Controls.Add(buttonDodajDoKoszyka);
            panelGlowny.Controls.Add(groupBoxKoszyk);
            panelGlowny.Controls.Add(groupBoxSzczegoly);
            panelGlowny.Controls.Add(labelProdukty);
            panelGlowny.Controls.Add(dataGridViewProdukty);
            panelGlowny.Dock = DockStyle.Fill;
            panelGlowny.Location = new Point(0, 176);
            panelGlowny.Name = "panelGlowny";
            panelGlowny.Size = new Size(1546, 646);
            panelGlowny.TabIndex = 1;
            // 
            // buttonPokazDodawanie
            // 
            buttonPokazDodawanie.Location = new Point(15, 593);
            buttonPokazDodawanie.Name = "buttonPokazDodawanie";
            buttonPokazDodawanie.Size = new Size(162, 39);
            buttonPokazDodawanie.TabIndex = 5;
            buttonPokazDodawanie.Text = "Dodaj nowy produkt";
            buttonPokazDodawanie.UseVisualStyleBackColor = true;
            buttonPokazDodawanie.Click += buttonPokazDodawanie_Click;
            // 
            // buttonDodajDoKoszyka
            // 
            buttonDodajDoKoszyka.Location = new Point(1367, 253);
            buttonDodajDoKoszyka.Name = "buttonDodajDoKoszyka";
            buttonDodajDoKoszyka.Size = new Size(162, 39);
            buttonDodajDoKoszyka.TabIndex = 4;
            buttonDodajDoKoszyka.Text = "Dodaj do koszyka";
            buttonDodajDoKoszyka.UseVisualStyleBackColor = true;
            buttonDodajDoKoszyka.Click += buttonDodajDoKoszyka_Click;
            // 
            // groupBoxKoszyk
            // 
            groupBoxKoszyk.Controls.Add(buttonZlozZamowienie);
            groupBoxKoszyk.Controls.Add(buttonWyczyscKoszyk);
            groupBoxKoszyk.Controls.Add(buttonUsunZKoszyka);
            groupBoxKoszyk.Controls.Add(labelSumaKoszyka);
            groupBoxKoszyk.Controls.Add(listBoxKoszyk);
            groupBoxKoszyk.Location = new Point(1051, 299);
            groupBoxKoszyk.Name = "groupBoxKoszyk";
            groupBoxKoszyk.Size = new Size(478, 333);
            groupBoxKoszyk.TabIndex = 3;
            groupBoxKoszyk.TabStop = false;
            groupBoxKoszyk.Text = "Koszyk";
            // 
            // buttonZlozZamowienie
            // 
            buttonZlozZamowienie.Location = new Point(16, 278);
            buttonZlozZamowienie.Name = "buttonZlozZamowienie";
            buttonZlozZamowienie.Size = new Size(162, 39);
            buttonZlozZamowienie.TabIndex = 4;
            buttonZlozZamowienie.Text = "Złóż zamówienie";
            buttonZlozZamowienie.UseVisualStyleBackColor = true;
            buttonZlozZamowienie.Click += buttonZlozZamowienie_Click;
            // 
            // buttonWyczyscKoszyk
            // 
            buttonWyczyscKoszyk.AutoSize = true;
            buttonWyczyscKoszyk.Location = new Point(381, 229);
            buttonWyczyscKoszyk.Name = "buttonWyczyscKoszyk";
            buttonWyczyscKoszyk.Size = new Size(80, 39);
            buttonWyczyscKoszyk.TabIndex = 3;
            buttonWyczyscKoszyk.Text = "Wyczyść";
            buttonWyczyscKoszyk.UseVisualStyleBackColor = true;
            buttonWyczyscKoszyk.Click += buttonWyczyscKoszyk_Click;
            // 
            // buttonUsunZKoszyka
            // 
            buttonUsunZKoszyka.Location = new Point(286, 229);
            buttonUsunZKoszyka.Name = "buttonUsunZKoszyka";
            buttonUsunZKoszyka.Size = new Size(80, 39);
            buttonUsunZKoszyka.TabIndex = 2;
            buttonUsunZKoszyka.Text = "Usuń";
            buttonUsunZKoszyka.UseVisualStyleBackColor = true;
            buttonUsunZKoszyka.Click += buttonUsunZKoszyka_Click;
            // 
            // labelSumaKoszyka
            // 
            labelSumaKoszyka.AutoSize = true;
            labelSumaKoszyka.Location = new Point(16, 238);
            labelSumaKoszyka.Name = "labelSumaKoszyka";
            labelSumaKoszyka.Size = new Size(95, 20);
            labelSumaKoszyka.TabIndex = 1;
            labelSumaKoszyka.Text = "Suma: 0,00 zł";
            // 
            // listBoxKoszyk
            // 
            listBoxKoszyk.FormattingEnabled = true;
            listBoxKoszyk.Location = new Point(16, 30);
            listBoxKoszyk.Name = "listBoxKoszyk";
            listBoxKoszyk.Size = new Size(445, 184);
            listBoxKoszyk.TabIndex = 0;
            // 
            // groupBoxSzczegoly
            // 
            groupBoxSzczegoly.Controls.Add(labelSzczegolyDodatkowe);
            groupBoxSzczegoly.Controls.Add(labelSzczegolyTyp);
            groupBoxSzczegoly.Controls.Add(labelSzczegolyStan);
            groupBoxSzczegoly.Controls.Add(labelSzczegolyProducent);
            groupBoxSzczegoly.Controls.Add(labelSzczegolyCena);
            groupBoxSzczegoly.Controls.Add(labelSzczegolyNazwa);
            groupBoxSzczegoly.Location = new Point(1051, 31);
            groupBoxSzczegoly.Name = "groupBoxSzczegoly";
            groupBoxSzczegoly.Size = new Size(478, 207);
            groupBoxSzczegoly.TabIndex = 2;
            groupBoxSzczegoly.TabStop = false;
            groupBoxSzczegoly.Text = "Szczegóły produktu";
            // 
            // labelSzczegolyDodatkowe
            // 
            labelSzczegolyDodatkowe.AutoSize = true;
            labelSzczegolyDodatkowe.Location = new Point(13, 172);
            labelSzczegolyDodatkowe.Name = "labelSzczegolyDodatkowe";
            labelSzczegolyDodatkowe.Size = new Size(89, 20);
            labelSzczegolyDodatkowe.TabIndex = 5;
            labelSzczegolyDodatkowe.Text = "Dodatkowe:";
            // 
            // labelSzczegolyTyp
            // 
            labelSzczegolyTyp.AutoSize = true;
            labelSzczegolyTyp.Location = new Point(13, 143);
            labelSzczegolyTyp.Name = "labelSzczegolyTyp";
            labelSzczegolyTyp.Size = new Size(35, 20);
            labelSzczegolyTyp.TabIndex = 4;
            labelSzczegolyTyp.Text = "Typ:";
            // 
            // labelSzczegolyStan
            // 
            labelSzczegolyStan.AutoSize = true;
            labelSzczegolyStan.Location = new Point(13, 114);
            labelSzczegolyStan.Name = "labelSzczegolyStan";
            labelSzczegolyStan.Size = new Size(41, 20);
            labelSzczegolyStan.TabIndex = 3;
            labelSzczegolyStan.Text = "Stan:";
            // 
            // labelSzczegolyProducent
            // 
            labelSzczegolyProducent.AutoSize = true;
            labelSzczegolyProducent.Location = new Point(13, 85);
            labelSzczegolyProducent.Name = "labelSzczegolyProducent";
            labelSzczegolyProducent.Size = new Size(79, 20);
            labelSzczegolyProducent.TabIndex = 2;
            labelSzczegolyProducent.Text = "Producent:";
            // 
            // labelSzczegolyCena
            // 
            labelSzczegolyCena.AutoSize = true;
            labelSzczegolyCena.Location = new Point(13, 56);
            labelSzczegolyCena.Name = "labelSzczegolyCena";
            labelSzczegolyCena.Size = new Size(45, 20);
            labelSzczegolyCena.TabIndex = 1;
            labelSzczegolyCena.Text = "Cena:";
            // 
            // labelSzczegolyNazwa
            // 
            labelSzczegolyNazwa.AutoSize = true;
            labelSzczegolyNazwa.Location = new Point(13, 27);
            labelSzczegolyNazwa.Name = "labelSzczegolyNazwa";
            labelSzczegolyNazwa.Size = new Size(54, 20);
            labelSzczegolyNazwa.TabIndex = 0;
            labelSzczegolyNazwa.Text = "Nazwa";
            // 
            // labelProdukty
            // 
            labelProdukty.AutoSize = true;
            labelProdukty.Location = new Point(15, 19);
            labelProdukty.Name = "labelProdukty";
            labelProdukty.Size = new Size(132, 20);
            labelProdukty.TabIndex = 1;
            labelProdukty.Text = "Produkty w sklepie";
            // 
            // dataGridViewProdukty
            // 
            dataGridViewProdukty.AllowUserToAddRows = false;
            dataGridViewProdukty.AllowUserToDeleteRows = false;
            dataGridViewProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdukty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukty.Location = new Point(15, 42);
            dataGridViewProdukty.MultiSelect = false;
            dataGridViewProdukty.Name = "dataGridViewProdukty";
            dataGridViewProdukty.ReadOnly = true;
            dataGridViewProdukty.RowHeadersWidth = 51;
            dataGridViewProdukty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdukty.Size = new Size(1007, 536);
            dataGridViewProdukty.TabIndex = 0;
            dataGridViewProdukty.SelectionChanged += dataGridViewProdukty_SelectionChanged;
            // 
            // buttonUsunProdukt
            // 
            buttonUsunProdukt.Location = new Point(860, 593);
            buttonUsunProdukt.Name = "buttonUsunProdukt";
            buttonUsunProdukt.Size = new Size(162, 39);
            buttonUsunProdukt.TabIndex = 6;
            buttonUsunProdukt.Text = "Usuń produkt";
            buttonUsunProdukt.UseVisualStyleBackColor = true;
            buttonUsunProdukt.Click += buttonUsunProdukt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 822);
            Controls.Add(panelGlowny);
            Controls.Add(panelGora);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Sklep z Grami Komputerowymi";
            panelGora.ResumeLayout(false);
            panelGora.PerformLayout();
            panelGlowny.ResumeLayout(false);
            panelGlowny.PerformLayout();
            groupBoxKoszyk.ResumeLayout(false);
            groupBoxKoszyk.PerformLayout();
            groupBoxSzczegoly.ResumeLayout(false);
            groupBoxSzczegoly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGora;
        private Button buttonHistoriaZamowien;
        private ComboBox comboBoxKlienci;
        private Label labelKlient;
        private Button buttonSzukajNazwa;
        private TextBox textBoxSzukajNazwa;
        private Label labelSzukajNazwa;
        private Label labelStatus;
        private TextBox textBoxCenaOd;
        private Label labelCenaOd;
        private Button buttonSzukajCena;
        private TextBox textBoxCenaDo;
        private Label labelCenaDo;
        private Button buttonPokazWszystkie;
        private Button buttonFiltruj;
        private ComboBox comboBoxPlatformaFiltr;
        private Label labelPlatformaFiltr;
        private ComboBox comboBoxGatunekFiltr;
        private Label labelGatunekFiltr;
        private ComboBox comboBoxTypFiltr;
        private Label labelTypFiltr;
        private Button buttonSortujCenaMalejaco;
        private Button buttonSortujCenaRosnaco;
        private Panel panelGlowny;
        private DataGridView dataGridViewProdukty;
        private GroupBox groupBoxSzczegoly;
        private Label labelSzczegolyTyp;
        private Label labelSzczegolyStan;
        private Label labelSzczegolyProducent;
        private Label labelSzczegolyCena;
        private Label labelSzczegolyNazwa;
        private Label labelProdukty;
        private GroupBox groupBoxKoszyk;
        private Button buttonZlozZamowienie;
        private Button buttonWyczyscKoszyk;
        private Button buttonUsunZKoszyka;
        private Label labelSumaKoszyka;
        private ListBox listBoxKoszyk;
        private Label labelSzczegolyDodatkowe;
        private Button buttonDodajDoKoszyka;
        private Button buttonPokazDodawanie;
        private Button buttonUsunProdukt;
    }
}
