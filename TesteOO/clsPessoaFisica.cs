using System;


namespace TesteOO
{
    public class clsPessoaFisica: clsPessoa
    {
        public string CPF { get; set; }



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
            return Nome + " Cresceu bem !";
        }
    }
}
