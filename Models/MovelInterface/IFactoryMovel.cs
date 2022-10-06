using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MovelCreate;

namespace Models.MovelInterface
{
    public interface IFactoryMovel
    {
        //ASSINATURA DE METODO FACTORY
        public abstract Movel FactoryMovel(int tipo);
    }
}
