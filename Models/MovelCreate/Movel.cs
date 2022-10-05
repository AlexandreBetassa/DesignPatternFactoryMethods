using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MovelCreate
{
    public class Movel
    {
        public String Tipo { get; set; }
        public List<string> Pecas { get; set; } = new();
    }
}
