namespace ProjektNr3_54058
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblTytulFormularza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLiczbaGrafu = new System.Windows.Forms.Label();
            this.txtZnacz = new System.Windows.Forms.TextBox();
            this.vz_btnMacierzWag = new System.Windows.Forms.Button();
            this.vz_btnPrzykladowaMacierzWag = new System.Windows.Forms.Button();
            this.vz_btnAkceptacjaMacierzWag = new System.Windows.Forms.Button();
            this.vz_btnWyznaczSciezkiWgrafie = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTytulFormularza
            // 
            this.lblTytulFormularza.AutoSize = true;
            this.lblTytulFormularza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTytulFormularza.Location = new System.Drawing.Point(230, 9);
            this.lblTytulFormularza.Name = "lblTytulFormularza";
            this.lblTytulFormularza.Size = new System.Drawing.Size(302, 25);
            this.lblTytulFormularza.TabIndex = 0;
            this.lblTytulFormularza.Text = "Algorytm Floyda-Warshalla ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis grafu:";
            // 
            // lblLiczbaGrafu
            // 
            this.lblLiczbaGrafu.AutoSize = true;
            this.lblLiczbaGrafu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLiczbaGrafu.Location = new System.Drawing.Point(23, 69);
            this.lblLiczbaGrafu.Name = "lblLiczbaGrafu";
            this.lblLiczbaGrafu.Size = new System.Drawing.Size(135, 13);
            this.lblLiczbaGrafu.TabIndex = 2;
            this.lblLiczbaGrafu.Text = "Liczba wierzcholkow grafu:";
            // 
            // txtZnacz
            // 
            this.txtZnacz.Location = new System.Drawing.Point(35, 100);
            this.txtZnacz.Name = "txtZnacz";
            this.txtZnacz.Size = new System.Drawing.Size(100, 20);
            this.txtZnacz.TabIndex = 3;
            // 
            // vz_btnMacierzWag
            // 
            this.vz_btnMacierzWag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vz_btnMacierzWag.Location = new System.Drawing.Point(26, 148);
            this.vz_btnMacierzWag.Name = "vz_btnMacierzWag";
            this.vz_btnMacierzWag.Size = new System.Drawing.Size(150, 52);
            this.vz_btnMacierzWag.TabIndex = 4;
            this.vz_btnMacierzWag.Text = "Utworz i pokaz macierz\r\nwag (sasiedztwa)";
            this.vz_btnMacierzWag.UseVisualStyleBackColor = true;
            this.vz_btnMacierzWag.Click += new System.EventHandler(this.vz_btnMacierzWag_Click);
            // 
            // vz_btnPrzykladowaMacierzWag
            // 
            this.vz_btnPrzykladowaMacierzWag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vz_btnPrzykladowaMacierzWag.Location = new System.Drawing.Point(26, 206);
            this.vz_btnPrzykladowaMacierzWag.Name = "vz_btnPrzykladowaMacierzWag";
            this.vz_btnPrzykladowaMacierzWag.Size = new System.Drawing.Size(150, 52);
            this.vz_btnPrzykladowaMacierzWag.TabIndex = 5;
            this.vz_btnPrzykladowaMacierzWag.Text = "Przykladowa macierz wag";
            this.vz_btnPrzykladowaMacierzWag.UseVisualStyleBackColor = true;
            this.vz_btnPrzykladowaMacierzWag.Click += new System.EventHandler(this.vz_btnPrzykladowaMacierzWag_Click);
            // 
            // vz_btnAkceptacjaMacierzWag
            // 
            this.vz_btnAkceptacjaMacierzWag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vz_btnAkceptacjaMacierzWag.Location = new System.Drawing.Point(26, 264);
            this.vz_btnAkceptacjaMacierzWag.Name = "vz_btnAkceptacjaMacierzWag";
            this.vz_btnAkceptacjaMacierzWag.Size = new System.Drawing.Size(150, 52);
            this.vz_btnAkceptacjaMacierzWag.TabIndex = 6;
            this.vz_btnAkceptacjaMacierzWag.Text = "Zaakceptuj wprowadzone dane w macierzy wag";
            this.vz_btnAkceptacjaMacierzWag.UseVisualStyleBackColor = true;
            this.vz_btnAkceptacjaMacierzWag.Click += new System.EventHandler(this.vz_btnAkceptacjaMacierzWag_Click);
            // 
            // vz_btnWyznaczSciezkiWgrafie
            // 
            this.vz_btnWyznaczSciezkiWgrafie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vz_btnWyznaczSciezkiWgrafie.Location = new System.Drawing.Point(26, 322);
            this.vz_btnWyznaczSciezkiWgrafie.Name = "vz_btnWyznaczSciezkiWgrafie";
            this.vz_btnWyznaczSciezkiWgrafie.Size = new System.Drawing.Size(150, 62);
            this.vz_btnWyznaczSciezkiWgrafie.TabIndex = 7;
            this.vz_btnWyznaczSciezkiWgrafie.Text = "Wyznacz najkrotsze sciezki w grafie wedlug algorytmu Floyda_Warshalla";
            this.vz_btnWyznaczSciezkiWgrafie.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(26, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "Wypisz najkrotsze trasy miedzy wezlami";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.vz_btnWyznaczSciezkiWgrafie);
            this.Controls.Add(this.vz_btnAkceptacjaMacierzWag);
            this.Controls.Add(this.vz_btnPrzykladowaMacierzWag);
            this.Controls.Add(this.vz_btnMacierzWag);
            this.Controls.Add(this.txtZnacz);
            this.Controls.Add(this.lblLiczbaGrafu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTytulFormularza);
            this.Name = "Form2";
            this.Text = "Laoratorium";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytulFormularza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLiczbaGrafu;
        private System.Windows.Forms.TextBox txtZnacz;
        private System.Windows.Forms.Button vz_btnMacierzWag;
        private System.Windows.Forms.Button vz_btnPrzykladowaMacierzWag;
        private System.Windows.Forms.Button vz_btnAkceptacjaMacierzWag;
        private System.Windows.Forms.Button vz_btnWyznaczSciezkiWgrafie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label vz_lblMacierzWag;
    }
}