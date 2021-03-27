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
            cla[7].squadra = "Inter";
            cla[8].squadra = "Juventus";
            cla[9].squadra = "Lazio";
            cla[10].squadra = "Milan";
            cla[11].squadra = "Napoli";
            cla[12].squadra = "Parma";
            cla[13].squadra = "Roma";
            cla[14].squadra = "Sampdoria";
            cla[15].squadra = "Sassuolo";
            cla[16].squadra = "Spezia";
            cla[17].squadra = "Torino";
            cla[18].squadra = "Udinese";
            cla[19].squadra = "Verona";
        }

}
}
