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
                    p[num].giornata = int.Parse(i[0].ToString());
                    p[num].dataOra = DateTime.Parse(i[1]);
                    p[num].stadio = i[2];
                    p[num].squadra1=i[3];
                    p[num].squadra2 = i[4];
                    string r = i[5];
                   
                    p[num].risultato1 = int.Parse(r.Split('-')[0]);
                    p[num].risultato2 = int.Parse(r.Split('-')[1]);

                    
                    num = num + 1;
                    line = sr.ReadLine();
                }
                //close the file

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            comboBox1.Items.Add("Tutte");
            for (int i = 1; i < 39; i++)
            {
                comboBox1.Items.Add($"Giornata {i}");
            }



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
            tabControl1.SelectTab(1);
        }

        private void btn_classifica_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btn_squadraMaxGol_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
    }
}
