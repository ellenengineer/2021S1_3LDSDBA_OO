using System;
using System.Collections.Generic;
using System.Text;

public enum TipoFelino
{
    Grande,
    Pequeno
}
namespace TesteOO
{
   public class clsFelino:clsMamiferos
    {
        public TipoFelino TipoFelino { get; set; }

        public override string Nascer(DateTime dtNasc)
        {
            return "Nosso Felino nasceu em " + dtNasc;
        }

        public override string Morrer()
        {
            return "Nosso felino infelizmente partiu dessa para melhor";
        }

        public override string Crescer()
        {
            return "que fofinho, nossa bolinha de pelo cresceu!";
        }
    }
}
