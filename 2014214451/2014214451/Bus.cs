using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public class Bus:Carro
    {
        TipoBus _TipoBus;

        public Bus():base()
        {
        }

        public int Bus(int numAsientos)
        {
            int numA = numAsientos;
            return numA;
        }
    }
}
