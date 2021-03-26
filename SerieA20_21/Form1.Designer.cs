
namespace SerieA20_21
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inserimento = new XanderUI.XUIButton();
            this.btn_partiteGiocate = new XanderUI.XUIButton();
            this.btn_classifica = new XanderUI.XUIButton();
            this.btn_squadraMaxGol = new XanderUI.XUIButton();
            this.btn_esci = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.btn_esci);
            this.panel2.Controls.Add(this.btn_squadraMaxGol);
            this.panel2.Controls.Add(this.btn_classifica);
            this.panel2.Controls.Add(this.btn_partiteGiocate);
            this.panel2.Controls.Add(this.btn_inserimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 49);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie A - Campionato 2020/2021";
            // 
            // btn_inserimento
            // 
            this.btn_inserimento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inserimento.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_inserimento.ButtonImage")));
            this.btn_inserimento.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_inserimento.ButtonText = "Inserimento";
            this.btn_inserimento.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_inserimento.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_inserimento.CornerRadius = 5;
            this.btn_inserimento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_inserimento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_inserimento.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_inserimento.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_inserimento.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_inserimento.Location = new System.Drawing.Point(0, 0);
            this.btn_inserimento.Name = "btn_inserimento";
            this.btn_inserimento.Size = new System.Drawing.Size(187, 49);
            this.btn_inserimento.TabIndex = 0;
            this.btn_inserimento.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_inserimento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_partiteGiocate
            // 
            this.btn_partiteGiocate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_partiteGiocate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_partiteGiocate.ButtonImage")));
            this.btn_partiteGiocate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_partiteGiocate.ButtonText = "Partite Giocate";
            this.btn_partiteGiocate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_partiteGiocate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_partiteGiocate.CornerRadius = 5;
            this.btn_partiteGiocate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_partiteGiocate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_partiteGiocate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_partiteGiocate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_partiteGiocate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_partiteGiocate.Location = new System.Drawing.Point(187, 0);
            this.btn_partiteGiocate.Name = "btn_partiteGiocate";
            this.btn_partiteGiocate.Size = new System.Drawing.Size(190, 49);
            this.btn_partiteGiocate.TabIndex = 1;
            this.btn_partiteGiocate.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_partiteGiocate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_classifica
            // 
            this.btn_classifica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_classifica.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_classifica.ButtonImage")));
            this.btn_classifica.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_classifica.ButtonText = "Classifica";
            this.btn_classifica.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_classifica.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_classifica.CornerRadius = 5;
            this.btn_classifica.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_classifica.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_classifica.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_classifica.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_classifica.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_classifica.Location = new System.Drawing.Point(377, 0);
            this.btn_classifica.Name = "btn_classifica";
            this.btn_classifica.Size = new System.Drawing.Size(168, 49);
            this.btn_classifica.TabIndex = 2;
            this.btn_classifica.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_classifica.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_squadraMaxGol
            // 
            this.btn_squadraMaxGol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_squadraMaxGol.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_squadraMaxGol.ButtonImage")));
            this.btn_squadraMaxGol.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_squadraMaxGol.ButtonText = "Squadra che ha segnato piùgol";
            this.btn_squadraMaxGol.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_squadraMaxGol.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_squadraMaxGol.CornerRadius = 5;
            this.btn_squadraMaxGol.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_squadraMaxGol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_squadraMaxGol.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_squadraMaxGol.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_squadraMaxGol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_squadraMaxGol.Location = new System.Drawing.Point(545, 0);
            this.btn_squadraMaxGol.Name = "btn_squadraMaxGol";
            this.btn_squadraMaxGol.Size = new System.Drawing.Size(207, 49);
            this.btn_squadraMaxGol.TabIndex = 3;
            this.btn_squadraMaxGol.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_squadraMaxGol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_esci
            // 
            this.btn_esci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_esci.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_esci.ButtonImage")));
            this.btn_esci.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_esci.ButtonText = "Esci";
            this.btn_esci.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_esci.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_esci.CornerRadius = 5;
            this.btn_esci.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_esci.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_esci.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_esci.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_esci.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_esci.Location = new System.Drawing.Point(752, 0);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.Size = new System.Drawing.Size(168, 49);
            this.btn_esci.TabIndex = 4;
            this.btn_esci.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_esci.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 550);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie A Campionato 2020/2021";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btn_inserimento;
        private XanderUI.XUIButton btn_esci;
        private XanderUI.XUIButton btn_squadraMaxGol;
        private XanderUI.XUIButton btn_classifica;
        private XanderUI.XUIButton btn_partiteGiocate;
    }
}

