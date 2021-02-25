using System;


namespace TesteOO
{
    public class clsPessoaJuridica: clsPessoa
    {
        public string CNPJ { get; set; }


        public override string Nascer(DateTime _dataNascimento)
        {
            return string.Concat(Nome, " fundou em ", DataNascimentoFundacao);
        }
        public override string Morrer()
        {
            return "Encerrou as atividades";
        }

        public override string Crescer()
        {
            return "Gerou lucro!";
        }
    }
}
