using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public abstract class Carro
    {
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        private Volante _Volante;
        private Parabrisa _Parabrisas;
        private Llanta _Llanta;
        private Asiento _Asiento;
        private TipoCarro _TipoCarro;
        
        public Carro()
        {

        }

        public  Carro(string numseriemotor, string numseriechasis,Volante volan,
           Parabrisa parabri, Llanta llant, Asiento asien, Bus bu)
        {
            NumSerieMotor = numseriemotor;
            NumSerieChasis = numseriechasis;
            _Volante = volan;
            _Parabrisas = parabri;
            _Llanta = llant;
            _Asiento = asien;
           
        }

        






    }
}
