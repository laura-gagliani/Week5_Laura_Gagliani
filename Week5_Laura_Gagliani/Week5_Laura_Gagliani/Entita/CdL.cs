using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Laura_Gagliani.Entita
{
    public class CdL
    {
        public string Codice { get; set; }
        public string Nome { get; set; }
        public int AnniDurata { get; set; }
        public int TotaleCFU { get; set; }
        public List<Corso> CorsiAssociati { get; set; } = new List<Corso>();
        public List<Studente> StudentiIscritti { get; set; } = new List<Studente>();


        CdL cdlMatematica = new CdL { Codice = "LM-40", Nome = "Matematica", AnniDurata =5, TotaleCFU = 300 };
        CdL cdlStoria = new CdL { Codice = "L-42", Nome = "Storia", AnniDurata =3, TotaleCFU = 180 };
        CdL cdlMedicina = new CdL { Codice = "LM-41", Nome = "Medicina", AnniDurata =6, TotaleCFU = 360 };

    }
}
