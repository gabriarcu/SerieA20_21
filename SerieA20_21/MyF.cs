using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieA20_21
{
    public class MyF
    {
        public struct partita
        {
            public int giornata;
            public DateTime dataOra;
            public string stadio;
            public string squadra1;
            public string squadra2;
            public int risultato1;
            public int risultato2;
        }

        public struct classifica
        {
            public string squadra;
            public int vinte;
            public int pareggiate;
            public int perse;
            public int punti;
        }
        public static void CaricaSquadre(classifica[] cla)
        {
            cla[0].squadra = "Atalanta";
            cla[1].squadra = "Benevento";
            cla[2].squadra = "Bologna";
            cla[3].squadra = "Cagliari";
            cla[4].squadra = "Crotone";
            cla[5].squadra = "Fiorentina";
            cla[6].squadra = "Genoa";
            cla[7].squadra = "Hellas Verona";
            cla[8].squadra = "Inter";
            cla[9].squadra = "Juventus";
            cla[10].squadra = "Lazio";
            cla[11].squadra = "Milan";
            cla[12].squadra = "Napoli";
            cla[13].squadra = "Parma";
            cla[14].squadra = "Roma";
            cla[15].squadra = "Sampdoria";
            cla[16].squadra = "Sassuolo";
            cla[17].squadra = "Spezia";
            cla[18].squadra = "Torino";
            cla[19].squadra = "Udinese";
            
        }
        public static void OrdinaClassifica(classifica[] cla)
        {
            for (int x=0;x<20;x++)
            {
                for (int y = 1; y < 19; y++)
                {
                    if(cla[x].punti>cla[y].punti)
                    {
                       
                        Array.Sort(cla, (x1, y1) => y1.punti.CompareTo(x1.punti));

                        Array.Sort(cla, delegate (classifica bla1, classifica bla2)
                        {
                            return bla2.punti.CompareTo(bla1.punti);
                        });

                    }
                }
            }
        }

    }
}
