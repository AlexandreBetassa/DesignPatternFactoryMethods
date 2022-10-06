using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ConcreteMovel;
using Models.MovelCreate;
using Models.MovelInterface;

namespace Models.MovelFactory
{
    public class MovelFactory : IFactoryMovel
    {
        //METODO FACTORY
        public Movel FactoryMovel(int tipo)
        {
            if (tipo == 1) return new Cadeira();
            else if (tipo == 2) return new Mesa();
            else if (tipo == 3) return new Sofa();
            else return null;
        }

    }
}
