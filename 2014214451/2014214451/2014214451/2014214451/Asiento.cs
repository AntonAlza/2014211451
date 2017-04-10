using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public class Asiento
    {
        public string NumSerieA { get; set; }
        private Cinturon _Cinturon;

        public Asiento()
        {
        }
        public Asiento(string numserie)
        {

            NumSerieA = numserie;
            _Cinturon = new Cinturon(generar_Serie_Cinturon(), generar_Metraje());
        }

        public string generar_Serie_Cinturon()
        {
            Random r = new Random();
            return r.Next(100, 250).ToString();
        }

        public int generar_Metraje()
        {
            Random r = new Random();
            return r.Next(100, 250);
        }

    }
}
