using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis2._0
{
    internal class Map
    {
        private int width;
        private int height;
        private char[,] grid;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new char[height, width];
            
        }
    }
}
