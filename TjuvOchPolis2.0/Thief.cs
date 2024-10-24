using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis2._0
{
    internal class Thief : Entity
    {
        public string StolenItems { get; set; } // Prylar tjuvarna har stulit
        public Thief(int x, int y) : base(x, y, 'T') { }
    }
}
