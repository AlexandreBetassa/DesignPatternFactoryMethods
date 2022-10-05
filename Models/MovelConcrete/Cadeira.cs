using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MovelCreate;

namespace Models.ConcreteMovel
{
    internal class Cadeira : Movel
    {
        public Cadeira()
        {
            Tipo = "Cadeira";
            Pecas.Add("Pés");
            Pecas.Add("Tampo");
            Pecas.Add("Tinta");
        }
    }
}
