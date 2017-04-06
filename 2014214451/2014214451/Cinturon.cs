using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public class Cinturon
    {
        string NumSerie {get; set;}
        int metraje;

        public Cinturon()
        {
            
        }
        public Cinturon(string _NumSerie, int _metraje)
        {
            NumSerie = _NumSerie;
            metraje = _metraje;
        }
    }
}
