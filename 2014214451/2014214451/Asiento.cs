using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public class Asiento
    {
        string NumSerieA { get; set; }
        private Cinturon _Cinturon;

        public Asiento(Cinturon NumSerie)
        {
            _Cinturon = NumSerie;
        }
        public Asiento(string _NumSerie)
        {
            NumSerieA = _NumSerie;      
        }

    }
}
