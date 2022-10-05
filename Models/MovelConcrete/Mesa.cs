using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MovelCreate;

namespace Models.ConcreteMovel
{
    internal class Mesa : Movel
    {
        public Mesa()
        {
            Tipo = "Mesa";
            Pecas.Add("Pés");
            Pecas.Add("Madeira");
            Pecas.Add("Tinta");
        }
    }
}
