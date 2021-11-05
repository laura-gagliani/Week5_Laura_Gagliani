using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Laura_Gagliani.Entita
{
    public class Studente
    {
        public int Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public bool RichiestaLaurea { get; set; }
        public int CFUAccumulati { get; set; }

        public Dictionary<Corso, bool> EsamiStudente { get; set; } = new Dictionary<Corso, bool>(); // suggerimento dictionary: ESAME, BOOL 

        public string CodiceCdL { get; set; } 
        public CdL CdL { get; set; }


       
    }
}
