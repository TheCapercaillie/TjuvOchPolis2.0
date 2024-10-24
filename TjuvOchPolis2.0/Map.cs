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
            ClearMap();
        }

        public void ClearMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[y, x] = ' ';
                }
            }
        }

        // Placera en entity på mappen
        public void PlaceEntity(Entity entity)
        {
            grid[entity.Y, entity.X] = entity.Symbol;
        }

        // Renderar mappen
        public void Render()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    char symbol = grid[y, x];

                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            
        }
       
    }
}
