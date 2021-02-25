using System;


namespace TesteOO
{
    public abstract class Animal : IAnimal
    {
        public string Nome { get; set; }

        public abstract string Crescer();
        public abstract string Morrer();
        public abstract string Nascer(DateTime dtNasc);
    }
}
