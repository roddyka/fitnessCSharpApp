using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevFitness.ConsoleApp
{
	public class Bebida : Refeicao
	{
        public Bebida(string descricao, int calorias, bool contemLactose) : base (descricao, calorias)
        {
            ContemLactose = contemLactose;
        }

		public bool ContemLactose { get; private set; }

        //sobrescevendo o metodo para quando for bebida
        public override void ImprimirMensagem()
        {
            Console.WriteLine($"{Descricao}, com {Calorias} calorias, e contem lactose {ContemLactose}");
        }
    }
}

