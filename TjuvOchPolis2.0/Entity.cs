using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis2._0
{
    internal class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; } // M för medborgare, P för polis, T tjuv

        public int DirectionX { get; set; }
        public int DirectionY { get; set; }

        private Random random = new Random();

        public Entity(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;

            
        }
    }
}
