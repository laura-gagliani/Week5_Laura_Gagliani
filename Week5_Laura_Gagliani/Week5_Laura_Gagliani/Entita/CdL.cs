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


        

    }
}
