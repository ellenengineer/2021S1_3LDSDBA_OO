using System;


namespace TesteOO
{
    public class clsPessoaFisica: clsPessoa
    {
        string _rg;
        public string CPF { get; set; }

        public string RG
        { 
            get { return _rg; }
            set { this._rg = value; }
        }

        public clsPessoaFisica()
        {
        }

        //ou

        public clsPessoaFisica(string _nome, DateTime _dtNasc) => (Nome, DataNascimentoFundacao) = (_nome, _dtNasc);


        public override string Nascer(DateTime _dataNascimento)
        {
            return string.Concat(Nome, " nasceu em ", DataNascimentoFundacao);
        }


        public override string Morrer()
        {
            return Nome + " não guentou e Morreu";
        }

        public override string Crescer()
        {
            return Nome + " está " + this.Caminhar() + " Cresceu bem !";
        }

    }
}
