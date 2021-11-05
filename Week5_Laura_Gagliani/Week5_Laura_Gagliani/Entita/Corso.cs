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



        
        
        

    }
}
