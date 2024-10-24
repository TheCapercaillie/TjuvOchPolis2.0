namespace TjuvOchPolis2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 100;
            int mapHeight = 25;

            // Skapar mappen
            Map map = new Map(mapWidth, mapHeight);

            // Skapar entities "personer"
            List<Citizen> citizens = new List<Citizen>();
            List<Police> police = new List<Police>();
            List<Thief> thieves = new List<Thief>();

            Random random = new Random();
            for (int i = 0; i < 30; i++) citizens.Add(new Citizen(random.Next(mapWidth), random.Next(mapHeight)));
            for (int i = 0; i < 30; i++) police.Add(new Police(random.Next(mapWidth), random.Next(mapHeight)));
            for (int i = 0; i < 15; i++) thieves.Add(new Thief(random.Next(mapWidth), random.Next(mapHeight)));

            int caughtThieves = 0;
            int successfulRobberies = 0;

            while (true)
            {
                map.ClearMap();

                // Placera entities
                foreach (Citizen citizen in citizens)
                {
                    citizen.Move(mapWidth, mapHeight);
                    map.PlaceEntity(citizen);
                }

                foreach (Police policeman in police)
                {
                    policeman.Move(mapWidth, mapHeight);
                    map.PlaceEntity(policeman);
                }

                foreach (Thief thief in thieves)
                {
                    thief.Move(mapWidth, mapHeight);
                    map.PlaceEntity(thief);
                }
                map.Render();

                // Tickrate
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
