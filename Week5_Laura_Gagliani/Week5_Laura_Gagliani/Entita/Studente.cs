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


        Studente sSto = new Studente { Matricola = 42, Nome = "Cosimo", Cognome = "Bianchini", AnnoNascita = 1999, RichiestaLaurea = true, CFUAccumulati = 180, CodiceCdL = "L-42" };
        Studente sMat = new Studente { Matricola = 40, Nome = "Sara", Cognome = "Giannini", AnnoNascita = 1993, RichiestaLaurea = false, CFUAccumulati = 240, CodiceCdL = "LM-40" };
        Studente sMed = new Studente { Matricola = 41, Nome = "Caterina", Cognome = "Cipriani", AnnoNascita = 2001, RichiestaLaurea = false, CFUAccumulati = 120, CodiceCdL = "LM-41" };
    }
}
