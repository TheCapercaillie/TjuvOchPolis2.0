using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis2._0
{
    internal class Citizen : Entity
    {
        public string[] Items = { "wallet", "watch", "phone", "key" }; // Prylar medborgare har
        public Citizen(int x, int y) : base(x, y, 'M') { }
    }
}
