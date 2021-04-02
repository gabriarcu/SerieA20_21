using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerieA20_21
{
    public partial class Form1 : Form
    {
        public MyF.partita[] p = new MyF.partita[1000];
        public MyF.partita[] p2 = new MyF.partita[1000];
        public MyF.classifica[] c = new MyF.classifica[20];
        int num=0;
        int num2 = 0;
        int tt = 0;
        public Form1()
        {
            string line;

            try
            {

                StreamReader sr = new StreamReader("seriea.csv");

                line = sr.ReadLine();
                

                while (line != null)
                {

                    string[] i = line.Split(',');
                    p[num].giornata = int.Parse(i[0]);
                    p[num].dataOra = DateTime.Parse(i[1]);
                    p[num].stadio = i[2];
                    p[num].squadra1=i[3];
                    p[num].squadra2 = i[4];
                    p[num].risultato1 = int.Parse(i[5]);
                    p[num].risultato2 = int.Parse(i[6]);

                    
                    num = num + 1;
                    line = sr.ReadLine();
                }
                //close the file

                sr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

            string line2;
            
            try
            {

                StreamReader sr2 = new StreamReader("dagiocare.csv");

                line2 = sr2.ReadLine();

                while (line2 != null)
                {

                    string[] i2 = line2.Split(',');
                    p2[num2].giornata = int.Parse(i2[0]);
                    p2[num2].dataOra = DateTime.Parse(i2[1]);
                    p2[num2].stadio = i2[2];
                    p2[num2].squadra1 = i2[3];
                    p2[num2].squadra2 = i2[4];
                   


                    num2 = num2 + 1;
                    line2 = sr2.ReadLine();
                }
                //close the file

                sr2.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            comboBox1.Items.Add("Tutte");
            for (int i = 1; i < 39; i++)
            {
                comboBox1.Items.Add($"Giornata {i}");
                lst_giornata.Items.Add($"Giornata {i}");
            }

            MyF.CaricaSquadre(c);
            for (int i = 0; i < 20; i++)
            {
                cbo_squadra.Items.Add(c[i].squadra);
                
            }



        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inserimento_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            int x = 0;
            while(x<num2)
            {
                if (!cbo_inserimento.Items.Contains($"Giornata {p2[x].giornata}"))
                    cbo_inserimento.Items.Add($"Giornata {p2[x].giornata}");
                x = x + 1;
            }
            

        }

        private void btn_partiteGiocate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            int y = 0;

            ListViewItem Riga;
            listView1.Items.Clear();

            while (y < num)
            {
                Riga = new ListViewItem(new string[]
                {

                    p[y].giornata.ToString(),
                    p[y].dataOra.ToString("d"),
                    p[y].dataOra.ToString("t"),
                    p[y].stadio,
                    p[y].squadra1,
                    p[y].squadra2,
                    $"{p[y].risultato1} - {p[y].risultato2}"


                }

                );

                listView1.Items.Add(Riga);


                y++;
            }

        }

        private void btn_elencoGiornata_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

        }

        private void btn_squadraMaxGol_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);


        }

        private void lst_giornata_SelectedIndexChanged(object sender, EventArgs e)
        {
            int giornata = lst_giornata.SelectedIndex + 1;
            box_partite.Text = $"Partite Giornata {giornata}";
            box_classifica.Text = $"Classifica dopo la Giornata {giornata}";

            //listView partite
            int y = 0;

            ListViewItem Riga2;
            listView2.Items.Clear();

            while (y < num)
            {
                if(p[y].giornata==giornata)
                {
                    Riga2 = new ListViewItem(new string[]
                    {
                        p[y].squadra1,
                        p[y].squadra2,
                        $"{p[y].risultato1} - {p[y].risultato2}"
                    }
                    

                    );

                    listView2.Items.Add(Riga2);
                }

                y++;
            }

            //listView Classifica

            int w = 0;

            for (int zz = 0; zz < 20; zz++)
            {
                c[zz].punti=0;
                c[zz].vinte = 0;
                c[zz].pareggiate = 0;
                c[zz].perse = 0;
            }
            

            while (w <num)
            {
                
                if (p[w].giornata<=giornata)
                {
                    if (p[w].risultato1 > p[w].risultato2)
                    {
                        for (int zz = 0; zz < 20; zz++)
                        {
                            if (p[w].squadra1 == c[zz].squadra)
                            {
                                c[zz].vinte++;
                                c[zz].punti += 3;
                            }
                            if (p[w].squadra2 == c[zz].squadra)
                            {
                                c[zz].perse++;
                                
                            }
                        }
                    }
                    if (p[w].risultato1 < p[w].risultato2)
                    {
                        for (int zz = 0; zz < 20; zz++)
                        {
                            if (p[w].squadra2 == c[zz].squadra)
                            {
                                c[zz].vinte++;
                                c[zz].punti += 3;
                            }
                            if (p[w].squadra1 == c[zz].squadra)
                            {
                                c[zz].perse++;
                            }
                        }
                    }
                    if (p[w].risultato1 == p[w].risultato2)
                    {
                        for (int zz = 0; zz < 20; zz++)
                        {
                            if (p[w].squadra1 == c[zz].squadra)
                            {
                                c[zz].pareggiate++;
                                c[zz].punti += 1;
                            }
                            if (p[w].squadra2 == c[zz].squadra)
                            {
                                c[zz].pareggiate++;
                                c[zz].punti += 1;
                            }
                        }
                    }
                }

                w = w + 1;
            }


            int z = 0;

            ListViewItem Riga3;
            listView3.Items.Clear();

            while (z < 20)
            {
                
                    Riga3 = new ListViewItem(new string[]
                    {
                        c[z].squadra,
                        c[z].punti.ToString(),
                        c[z].vinte.ToString(),
                        c[z].pareggiate.ToString(),
                        c[z].perse.ToString(),
                    }

                    );

                    listView3.Items.Add(Riga3);
                

                z++;
            }



        }


        private void cbo_inserimento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_salva.Visible = true;

            string sceltagiornata = cbo_inserimento.SelectedItem.ToString();
            string[] s = sceltagiornata.Split(' ');
            txt_giornata.Text = s[1];
            panel7.Controls.Clear();
            panel7.Controls.Add(btn_salva);
            int xy = 0;
            int cy = 25;
            while (xy < num2)
            {
                if (p2[xy].giornata == int.Parse(txt_giornata.Text))
                {

                    TextBox t1 = new TextBox();
                    t1.Name = $"txt_data{xy + 1}";
                    t1.Location = new Point(5, (cy));
                    t1.Text = p2[xy].dataOra.ToString("g"); ;
                    t1.AutoSize = false;
                    t1.Width = 179;
                    t1.Height = 31;
                    t1.ReadOnly = true;
                    t1.Visible = true;
                    panel7.Controls.Add(t1);

                    TextBox t2 = new TextBox();
                    t2.Name = $"txt_stadio{xy + 1}";
                    t2.Location = new Point(196, (cy));
                    t2.Text = p2[xy].stadio;
                    t2.AutoSize = false;
                    t2.Width = 227;
                    t2.Height = 31;
                    t2.ReadOnly = true;
                    t2.Visible = true;
                    panel7.Controls.Add(t2);

                    TextBox t3 = new TextBox();
                    t3.Name = $"txt_squadra1_{xy + 1}";
                    t3.Location = new Point(440, (cy));
                    t3.Text = p2[xy].squadra1;
                    t3.AutoSize = false;
                    t3.Width = 227;
                    t3.Height = 31;
                    t3.ReadOnly = true;
                    t3.Visible = true;
                    panel7.Controls.Add(t3);

                    TextBox t4 = new TextBox();
                    t4.Name = $"txt_squadra2_{xy + 1}";
                    t4.Location = new Point(685, (cy));
                    t4.Text = p2[xy].squadra2;
                    t4.AutoSize = false;
                    t4.Width = 227;
                    t4.Height = 31;
                    t4.ReadOnly = true;
                    t4.Visible = true;
                    panel7.Controls.Add(t4);

                    TextBox t5 = new TextBox();
                    t5.Name = $"txt_ris1_{xy + 1}";
                    t5.Location = new Point(937, (cy));
                    t5.Text = "";
                    t5.AutoSize = false;
                    t5.Width = 50;
                    t5.Height = 31;
                    t5.ReadOnly = false;
                    t5.Visible = true;
                    panel7.Controls.Add(t5);

                    Label l1 = new Label();
                    l1.Location = new Point(993, (cy));
                    l1.Text = "-";
                    l1.AutoSize = false;
                    l1.Width = 18;
                    l1.Height = 24;
                    l1.Visible = true;
                    panel7.Controls.Add(l1);

                    TextBox t6 = new TextBox();
                    t6.Name = $"txt_ris2_{xy + 1}";
                    t6.Location = new Point(1017, (cy));
                    t6.Text = "";
                    t6.AutoSize = false;
                    t6.Width = 50;
                    t6.Height = 31;
                    t6.ReadOnly = false;
                    t6.Visible = true;
                    panel7.Controls.Add(t6);

                    cy = cy + 37;
                    tt = tt + 1;


                }
                xy = xy + 1;
            }
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            int yy = 0;
            while(yy<tt)
            {
                p[num].giornata = int.Parse(txt_giornata.Text);
                //p[num].dataOra =
                //p[num].dataOra=
                //p[num].stadio=
                //p[num].squadra1=
                //p[num].squadra2 =
                //p[num].risultato1=
                //p[num].risultato2 =
                yy = yy + 1;
                num = num + 1;
            }

            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader("dagiocare.csv"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] l = line.Split(',');
                    if (l[0] != txt_giornata.Text)
                        sw.WriteLine(line);
                }
            }

            File.Delete("dagiocare.csv");
            File.Move(tempFile, "dagiocare.csv");

            string line3;
            int num2 = 0;

            try
            {

                StreamReader sr3 = new StreamReader("dagiocare.csv");

                line3 = sr3.ReadLine();

                while (line3 != null)
                {

                    string[] i3 = line3.Split(',');
                    p2[num2].giornata = int.Parse(i3[0]);
                    p2[num2].dataOra = DateTime.Parse(i3[1]);
                    p2[num2].stadio = i3[2];
                    p2[num2].squadra1 = i3[3];
                    p2[num2].squadra2 = i3[4];



                    num2 = num2 + 1;
                    line3 = sr3.ReadLine();
                }
                //close the file

                sr3.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Exception: " + e1.Message);
            }
            panel7.Controls.Clear();
            int x = 0;
            cbo_inserimento.Items.Clear();
            cbo_inserimento.Text = "";
            while (x < num2)
            {
                if (!cbo_inserimento.Items.Contains($"Giornata {p2[x].giornata}"))
                    cbo_inserimento.Items.Add($"Giornata {p2[x].giornata}");
                x = x + 1;
            }
        }

        private void cbo_squadra_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selezione = cbo_squadra.SelectedItem.ToString();
            int x = 0;
            

            while (x<num)
            {
                if(p[x].squadra1==selezione)
                {
                    //grafico_gol.Items.Add(p[x].risultato1);
                    //grafico_.Items.Add(p[x].risultato1);
                    //grafico_2.numbers.Add(p[x].risultato1);
                }
                if (p[x].squadra2 == selezione)
                {
                    //grafico_gol.Items.Add(p[x].risultato2);
                    //grafico_.Items.Add(p[x].risultato2);
                    //grafico_2.numbers.Add(p[x].risultato2);
                }
                x = x + 1;
            }
            
        }
    }
}
