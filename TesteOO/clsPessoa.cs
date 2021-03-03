using System;


namespace TesteOO
{
    public abstract class clsPessoa : Animal
    {

        protected DateTime _dataNascimento;
        public DateTime DataNascimentoFundacao { get; set; }

        public clsPessoa(DateTime _dtNasc)
        {
            this.DataNascimentoFundacao = _dtNasc;
        }

        public clsPessoa() => (DataNascimentoFundacao) = (_dataNascimento);
        public override string Nascer(DateTime _dataNascimento)
        {
            return string.Concat(this.Nome, " nasceu em ", _dataNascimento);
        }


        public override string Morrer()
        {
            return "Morreu";
        }

        public override string Crescer()
        {
            return "Cresceu!";
        }

        protected string Caminhar()
        {
            return "Caminhando";
        }

    }
}
