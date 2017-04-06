using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public abstract class Carro
    {
        string NumSerieMotor { set; get; }
        string NumSerieChasis { set; get; }
        private Asiento _Asiento;
        private Llanta _Llanta;
        private Parabrisa _Parabrisa;
        private Volante _Volante;

        public void Carro()
        {
        }






    }
}
