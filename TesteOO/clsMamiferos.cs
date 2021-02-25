using System;
using System.Collections.Generic;
using System.Text;

namespace TesteOO
{
    public abstract class clsMamiferos:IAnimal
    {
        public int QtdePatas { get; set; }
        public bool IsCarnivoro { get; set; }

        public string  Nome { get; set; }
        public DateTime DtNasc { get; set; }

        public abstract string Nascer(DateTime dtNasc);
        public abstract string Crescer();
        public abstract string Morrer();

    }
}
