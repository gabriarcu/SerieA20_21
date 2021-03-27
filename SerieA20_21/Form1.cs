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
        public MyF.classifica[] c = new MyF.classifica[20];
        int num=0;
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



        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inserimento_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
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

            int z = 0;

            ListViewItem Riga3;
            listView3.Items.Clear();

            while (z < 20)
            {
                
                    Riga3 = new ListViewItem(new string[]
                    {
                        c[z].squadra
                    }

                    );

                    listView3.Items.Add(Riga3);
                

                z++;
            }



        }
    }
}
