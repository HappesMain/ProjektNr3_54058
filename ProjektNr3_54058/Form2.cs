using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr3_54058
{
    public partial class Form2 : Form
    {

        const int Margines = 10;
        const int MarginesFormularz = 20;
        const ushort SzerokoscKolumny = 60;
        const short WysokoscWiersza = 23;

        Font FontOpisuKontrolek = new Font("Times New Roman", 12, FontStyle.Italic);

        Label lblMacierzWag;
        Label lblMacierzOdleglosci;
        Label lblMacierzWazlowPosrednich;
        Label lblTrasy;

        DataGridView dgvMarierzWag;
        DataGridView dgvMarierzWazlowPosrednich;
        DataGridView dgvMacierzOdleglosci;

        RichTextBox rtbTrasa;

        ushort LiczbaWierzcholkowGrafu;
        static int[,] MacierzWag;
        static int[,] MacierzWazlowPosrednich;
        static int[,] MacierzOdleglosci;

        const short BrakDrogi = short.MaxValue;
        int[,] macierzWag;
        int[,] macierzOdleglosci;
        int[,] macierzWazlowPosrednich;
        public void Graf_MacierzWag(int[,] MacierzWag)
        {
            macierzWag = (int[,])MacierzWag.Clone();
            macierzOdleglosci = new int[macierzWag.GetLength(0), macierzWag.GetLength(1)];
            macierzOdleglosci = (int[,])macierzWag.Clone();

            for (int j = 0; j < MacierzWag.GetLength(0); j++)
                for (int i = 0; i < MacierzWag.GetLength(1); i++)
                    if (j == i)
                        MacierzOdleglosci[j, i] = BrakDrogi;

            macierzWazlowPosrednich = new int[macierzWag.GetLength(0), macierzWag.GetLength(1)];

            for (int j = 0; j < macierzWazlowPosrednich.GetLength(0); j++)
                for (int i = 0; i < macierzWazlowPosrednich.GetLength(1); i++)
                    MacierzWazlowPosrednich[j, i] = 0;
        }
        
        public Form2()
        {
            InitializeComponent();
        }
       
        private void vz_btnMacierzWag_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (!ushort.TryParse(txtZnacz.Text, out LiczbaWierzcholkowGrafu))
            {
                errorProvider1.SetError(txtZnacz, "Error: wystapil niedozwolony znak w zapisie liczby wezlow grafu");
                return;
            }

            lblMacierzWag = new Label();
            lblMacierzWag.Font = FontOpisuKontrolek;
            lblMacierzWag.Text = "Macierz wag (sasiedztwa";
            lblMacierzWag.AutoSize = true;
            lblMacierzWag.Location = new Point(vz_btnMacierzWag.Location.X + vz_btnMacierzWag.Width + Margines,
                lblTytulFormularza.Top + lblTytulFormularza.Height + Margines);
            lblMacierzWag.Visible = true;
            Controls.Add(lblMacierzWag);
            dgvMarierzWag = new DataGridView();
            dgvMarierzWag.Location = new Point(lblLiczbaGrafu.Location.X + lblLiczbaGrafu.Width + Margines,
                lblMacierzWag.Top + lblMacierzWag.Height + Margines);
            dgvMarierzWag.Size = new Size((LiczbaWierzcholkowGrafu + 1) * SzerokoscKolumny,
                (LiczbaWierzcholkowGrafu + 1) * WysokoscWiersza);
            dgvMarierzWag.AutoResizeRows();
            dgvMarierzWag.ColumnCount = LiczbaWierzcholkowGrafu;
            dgvMarierzWag.ColumnHeadersVisible = true;
            dgvMarierzWag.ReadOnly = false;
            dgvMarierzWag.AllowUserToAddRows = false;
            dgvMarierzWag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarierzWag.MultiSelect = false;

            DataGridViewCellStyle StylHeaderaKolumn = new DataGridViewCellStyle();
            StylHeaderaKolumn.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderaKolumn.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMarierzWag.ColumnHeadersDefaultCellStyle = StylHeaderaKolumn;

            DataGridViewCellStyle StyleHeaderaWierzy = new DataGridViewCellStyle();
            StyleHeaderaWierzy.Font = new Font("Arial", 10, FontStyle.Bold);
            StyleHeaderaWierzy.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMarierzWag.RowHeadersDefaultCellStyle = StyleHeaderaWierzy;

            for(ushort i = 0; i < LiczbaWierzcholkowGrafu; i++)
            {
                dgvMarierzWag.Columns[i].HeaderText = "(" + i + ")";
                dgvMarierzWag.Columns[i].Width = SzerokoscKolumny;
            }

            for (ushort i = 0; i < LiczbaWierzcholkowGrafu; i++)
                dgvMarierzWag.Rows.Add();

            for (ushort i = 0; i < LiczbaWierzcholkowGrafu; i++)
                dgvMarierzWag.Rows[i].HeaderCell.Value = "(" + i + ")";

            dgvMarierzWag.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMarierzWag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarierzWag.AutoResizeColumnHeadersHeight();
            dgvMarierzWag.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            Controls.Add(dgvMarierzWag);

            for (ushort i = 0; i < dgvMarierzWag.Rows.Count; i++)
                for (ushort j = 0; j < dgvMarierzWag.Columns.Count; j++)
                    dgvMarierzWag.Rows[i].Cells[j].Value = "";

            vz_btnMacierzWag.Enabled = false;
            txtZnacz.Enabled = false;
            vz_btnPrzykladowaMacierzWag.Enabled = true;
            vz_btnAkceptacjaMacierzWag.Enabled = true;
        }

        private void vz_btnPrzykladowaMacierzWag_Click(object sender, EventArgs e)
        {
            int[,] PrzykladowyGraf = { { BrakDrogi, BrakDrogi, BrakDrogi, 3, BrakDrogi},
                                       { 3, BrakDrogi, 4, 1, BrakDrogi},
                                       { BrakDrogi, -1, BrakDrogi, 2, BrakDrogi},
                                       { -2, 5, BrakDrogi, BrakDrogi, 2},
                                       { BrakDrogi, BrakDrogi, 1, BrakDrogi, BrakDrogi} 
                                      };
            if(LiczbaWierzcholkowGrafu != 5)
            {
                errorProvider1.SetError(vz_btnPrzykladowaMacierzWag, "Error: przykladowa" +
                    " macierz wag moze byc wstawiona tylko dla grafu 0 5 wezlach");
                return;
            }
            errorProvider1.Dispose();

            for (ushort i = 0; i < dgvMarierzWag.Rows.Count; i++)
                for (ushort j = 0; j < dgvMarierzWag.Columns.Count; j++)
                    if (PrzykladowyGraf[i, j] == BrakDrogi)
                        dgvMarierzWag.Rows[i].Cells[j].Value = "";
                    else
                        dgvMarierzWag.Rows[i].Cells[j].Value = PrzykladowyGraf[i, j];
        }

        private void vz_btnAkceptacjaMacierzWag_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            dgvMarierzWag.ReadOnly = true;

            vz_btnAkceptacjaMacierzWag.Enabled = false;
            vz_btnPrzykladowaMacierzWag.Enabled = false;

            vz_btnWyznaczSciezkiWgrafie.Enabled = true;
        }
    }

    
}
