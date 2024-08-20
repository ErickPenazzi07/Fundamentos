using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Animal
    {

        public string Especie { get; set; }
        public string Nome { get; set; }

        public void emitirSom()
        {
            Console.WriteLine("Emitiu um Som");
        }

    }
}
