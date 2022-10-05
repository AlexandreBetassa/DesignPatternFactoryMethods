using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MovelCreate;

namespace Models.ConcreteMovel
{
    internal class Sofa : Movel
    {
        public Sofa()
        {
            Tipo = "Sofa";
            Pecas.Add("Forro");
            Pecas.Add("Apoio de braço");
            Pecas.Add("Revestimento");
            Pecas.Add("Madeira");
        }
    }
}
