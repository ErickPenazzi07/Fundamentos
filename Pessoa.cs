using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void DiaAniversario()
        {
            Idade += 1;

            Console.WriteLine("Hoje " + Nome + " Está completando " + Idade + " Anos");
        }

    }
}
