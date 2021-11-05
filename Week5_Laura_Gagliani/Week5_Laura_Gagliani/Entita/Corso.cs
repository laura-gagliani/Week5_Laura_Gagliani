using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Laura_Gagliani.Entita
{
    public class Corso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CFU { get; set; }
        public string CodiceCdL { get; set; } //FK 
        public CdL CdL { get; set; }



        Corso cSto1 = new Corso {Id = 4201, Nome = "Storia medievale", CFU = 60, CodiceCdL = "L-42" };
        Corso cSto2 = new Corso {Id = 4202, Nome = "Storia delle religioni", CFU = 60, CodiceCdL = "L-42" };
        Corso cSto3 = new Corso {Id = 4203, Nome = "Storia contemporanea", CFU = 60, CodiceCdL = "L-42" };

        Corso cMat1 = new Corso {Id = 4001, Nome = "Algebra lineare", CFU = 60, CodiceCdL = "LM-40" };
        Corso cMat2 = new Corso {Id = 4002, Nome = "Analisi I e II", CFU = 120, CodiceCdL = "LM-40" };
        Corso cMat3 = new Corso {Id = 4003, Nome = "Statistica", CFU = 60, CodiceCdL = "LM-40" };
        Corso cMat4 = new Corso {Id = 4004, Nome = "Modelli geometrici", CFU = 60, CodiceCdL = "LM-40" };

        Corso cMed1 = new Corso {Id = 4101, Nome = "Anatomia", CFU = 120, CodiceCdL = "LM-41" };
        Corso cMed2 = new Corso {Id = 4102, Nome = "Citologia", CFU = 60, CodiceCdL = "LM-41" };
        Corso cMed3 = new Corso {Id = 4103, Nome = "Diagnostica per immagini", CFU = 60, CodiceCdL = "LM-41" };
        Corso cMed4 = new Corso {Id = 4104, Nome = "Patologia generale", CFU = 60, CodiceCdL = "LM-41" };
        Corso cMed5 = new Corso {Id = 4105, Nome = "Clinica chirurgica", CFU = 60, CodiceCdL = "LM-41" };
        
        

    }
}
