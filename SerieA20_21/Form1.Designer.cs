
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.box_classifica = new XanderUI.XUICustomGroupbox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.box_partite = new XanderUI.XUICustomGroupbox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.lst_giornata = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_esci = new XanderUI.XUIButton();
            this.btn_squadraMaxGol = new XanderUI.XUIButton();
            this.btn_elencoGiornata = new XanderUI.XUIButton();
            this.btn_partiteGiocate = new XanderUI.XUIButton();
            this.btn_inserimento = new XanderUI.XUIButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.box_classifica.SuspendLayout();
            this.box_partite.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 578);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 465);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserimento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1113, 428);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Partite per giornata";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.box_classifica);
            this.panel6.Controls.Add(this.box_partite);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(158, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(955, 428);
            this.panel6.TabIndex = 1;
            // 
            // box_classifica
            // 
            this.box_classifica.BorderColor = System.Drawing.Color.DodgerBlue;
            this.box_classifica.BorderWidth = 1;
            this.box_classifica.Controls.Add(this.listView3);
            this.box_classifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_classifica.Location = new System.Drawing.Point(411, 0);
            this.box_classifica.Name = "box_classifica";
            this.box_classifica.ShowText = true;
            this.box_classifica.Size = new System.Drawing.Size(544, 428);
            this.box_classifica.TabIndex = 3;
            this.box_classifica.TabStop = false;
            this.box_classifica.Text = "Classifica";
            this.box_classifica.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 27);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(538, 398);
            this.listView3.TabIndex = 12;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Squadra";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Punti";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Vinte";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Pareggiate";
            this.columnHeader14.Width = 110;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Perse";
            // 
            // box_partite
            // 
            this.box_partite.BorderColor = System.Drawing.Color.DodgerBlue;
            this.box_partite.BorderWidth = 1;
            this.box_partite.Controls.Add(this.listView2);
            this.box_partite.Dock = System.Windows.Forms.DockStyle.Left;
            this.box_partite.Location = new System.Drawing.Point(0, 0);
            this.box_partite.Name = "box_partite";
            this.box_partite.ShowText = true;
            this.box_partite.Size = new System.Drawing.Size(411, 428);
            this.box_partite.TabIndex = 2;
            this.box_partite.TabStop = false;
            this.box_partite.Text = "Partite";
            this.box_partite.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(405, 398);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Squadra1";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Squadra 2";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Risultato";
            this.columnHeader10.Width = 100;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lst_giornata);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 428);
            this.panel5.TabIndex = 0;
            // 
            // lst_giornata
            // 
            this.lst_giornata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_giornata.FormattingEnabled = true;
            this.lst_giornata.ItemHeight = 24;
            this.lst_giornata.Location = new System.Drawing.Point(0, 0);
            this.lst_giornata.Name = "lst_giornata";
            this.lst_giornata.Size = new System.Drawing.Size(158, 428);
            this.lst_giornata.TabIndex = 0;
            this.lst_giornata.SelectedIndexChanged += new System.EventHandler(this.lst_giornata_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Elenco Partite Giocate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1107, 380);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Giornata";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ora";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stadio";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Squadra1";
            this.columnHeader5.Width = 220;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Squadra 2";
            this.columnHeader6.Width = 220;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Risultato";
            this.columnHeader7.Width = 110;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 42);
            this.panel4.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(498, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scegli la giornata";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1113, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Classifica";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1113, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SquadraMaxGol";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.btn_esci);
            this.panel2.Controls.Add(this.btn_squadraMaxGol);
            this.panel2.Controls.Add(this.btn_elencoGiornata);
            this.panel2.Controls.Add(this.btn_partiteGiocate);
            this.panel2.Controls.Add(this.btn_inserimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 49);
            this.panel2.TabIndex = 2;
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
            this.btn_esci.Location = new System.Drawing.Point(808, 0);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.Size = new System.Drawing.Size(168, 49);
            this.btn_esci.TabIndex = 4;
            this.btn_esci.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_esci.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
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
            this.btn_squadraMaxGol.Location = new System.Drawing.Point(601, 0);
            this.btn_squadraMaxGol.Name = "btn_squadraMaxGol";
            this.btn_squadraMaxGol.Size = new System.Drawing.Size(207, 49);
            this.btn_squadraMaxGol.TabIndex = 3;
            this.btn_squadraMaxGol.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_squadraMaxGol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_squadraMaxGol.Click += new System.EventHandler(this.btn_squadraMaxGol_Click);
            // 
            // btn_elencoGiornata
            // 
            this.btn_elencoGiornata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_elencoGiornata.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_elencoGiornata.ButtonImage")));
            this.btn_elencoGiornata.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_elencoGiornata.ButtonText = "Elenco per giornata";
            this.btn_elencoGiornata.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_elencoGiornata.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_elencoGiornata.CornerRadius = 5;
            this.btn_elencoGiornata.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_elencoGiornata.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_elencoGiornata.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_elencoGiornata.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_elencoGiornata.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_elencoGiornata.Location = new System.Drawing.Point(377, 0);
            this.btn_elencoGiornata.Name = "btn_elencoGiornata";
            this.btn_elencoGiornata.Size = new System.Drawing.Size(224, 49);
            this.btn_elencoGiornata.TabIndex = 2;
            this.btn_elencoGiornata.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_elencoGiornata.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_elencoGiornata.Click += new System.EventHandler(this.btn_elencoGiornata_Click);
            // 
            // btn_partiteGiocate
            // 
            this.btn_partiteGiocate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_partiteGiocate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_partiteGiocate.ButtonImage")));
            this.btn_partiteGiocate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_partiteGiocate.ButtonText = "Elenco Partite";
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
            this.btn_partiteGiocate.Click += new System.EventHandler(this.btn_partiteGiocate_Click);
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
            this.btn_inserimento.Click += new System.EventHandler(this.btn_inserimento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 64);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie A - Campionato 2020/2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 578);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie A Campionato 2020/2021";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.box_classifica.ResumeLayout(false);
            this.box_classifica.PerformLayout();
            this.box_partite.ResumeLayout(false);
            this.box_partite.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private XanderUI.XUIButton btn_elencoGiornata;
        private XanderUI.XUIButton btn_partiteGiocate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lst_giornata;
        private System.Windows.Forms.Panel panel6;
        private XanderUI.XUICustomGroupbox box_partite;
        private XanderUI.XUICustomGroupbox box_classifica;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

