namespace SklepZGramiApp
{
    partial class FormZamowienia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewZamowienia = new DataGridView();
            groupBoxSzczegolyZamowienia = new GroupBox();
            listBoxProduktyZamowienia = new ListBox();
            labelSzczegolyZamowienia = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowienia).BeginInit();
            groupBoxSzczegolyZamowienia.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewZamowienia
            // 
            dataGridViewZamowienia.AllowUserToAddRows = false;
            dataGridViewZamowienia.AllowUserToDeleteRows = false;
            dataGridViewZamowienia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZamowienia.Location = new Point(12, 12);
            dataGridViewZamowienia.MultiSelect = false;
            dataGridViewZamowienia.Name = "dataGridViewZamowienia";
            dataGridViewZamowienia.ReadOnly = true;
            dataGridViewZamowienia.RowHeadersWidth = 51;
            dataGridViewZamowienia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewZamowienia.Size = new Size(776, 196);
            dataGridViewZamowienia.TabIndex = 0;
            dataGridViewZamowienia.SelectionChanged += dataGridViewZamowienia_SelectionChanged;
            // 
            // groupBoxSzczegolyZamowienia
            // 
            groupBoxSzczegolyZamowienia.Controls.Add(listBoxProduktyZamowienia);
            groupBoxSzczegolyZamowienia.Controls.Add(labelSzczegolyZamowienia);
            groupBoxSzczegolyZamowienia.Location = new Point(12, 214);
            groupBoxSzczegolyZamowienia.Name = "groupBoxSzczegolyZamowienia";
            groupBoxSzczegolyZamowienia.Size = new Size(776, 315);
            groupBoxSzczegolyZamowienia.TabIndex = 1;
            groupBoxSzczegolyZamowienia.TabStop = false;
            groupBoxSzczegolyZamowienia.Text = "Szczegóły zamówienia";
            // 
            // listBoxProduktyZamowienia
            // 
            listBoxProduktyZamowienia.FormattingEnabled = true;
            listBoxProduktyZamowienia.Location = new Point(6, 143);
            listBoxProduktyZamowienia.Name = "listBoxProduktyZamowienia";
            listBoxProduktyZamowienia.Size = new Size(764, 164);
            listBoxProduktyZamowienia.TabIndex = 1;
            // 
            // labelSzczegolyZamowienia
            // 
            labelSzczegolyZamowienia.Location = new Point(7, 29);
            labelSzczegolyZamowienia.Name = "labelSzczegolyZamowienia";
            labelSzczegolyZamowienia.Size = new Size(763, 102);
            labelSzczegolyZamowienia.TabIndex = 0;
            labelSzczegolyZamowienia.Text = "Wybierz zamówienie z tabeli";
            // 
            // FormZamowienia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(groupBoxSzczegolyZamowienia);
            Controls.Add(dataGridViewZamowienia);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormZamowienia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historia zamówień";
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowienia).EndInit();
            groupBoxSzczegolyZamowienia.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewZamowienia;
        private GroupBox groupBoxSzczegolyZamowienia;
        private ListBox listBoxProduktyZamowienia;
        private Label labelSzczegolyZamowienia;
    }
}