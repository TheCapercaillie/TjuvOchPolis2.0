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

            SetRandomDirection();
        }

        public void SetRandomDirection()
        {
            // Lista av möjliga riktningar
            int[,] directions = {
            { -1,  0 }, // Vänster
            {  1,  0 }, // Höger
            {  0, -1 }, // Upp
            {  0,  1 }, // Ner
            { -1, -1 }, // Diagonalt upp åt vänster
            { -1,  1 }, // Diagonalt ner åt vänster
            {  1, -1 }, // Diagonalt upp åt höger
            {  1,  1 }  // Diagonalt ner år höger
            };

            // Väljer en random riktning
            int index = random.Next(directions.GetLength(0));

            // Rörelsen tillämpas
            DirectionX = directions[index, 0];
            DirectionY = directions[index, 1];


        }
    }
}
