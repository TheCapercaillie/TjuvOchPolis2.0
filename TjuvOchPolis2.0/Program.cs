namespace TjuvOchPolis2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 100; // Mappens dimensioner
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

                    // Checkar collisioner med citizens
                    Citizen robbedCitizen = citizens.FirstOrDefault(c => c.X == thief.X && c.Y == thief.Y);
                    if (robbedCitizen != null && thief.StolenItems == null)
                    {
                        // Råna citizen
                        thief.StolenItems = robbedCitizen.Items[random.Next(robbedCitizen.Items.Length)];
                        Console.WriteLine($"A thief stole a {thief.StolenItems} from a citizen!");
                        successfulRobberies++;
                        // Pausa i 2 sek
                        Thread.Sleep(2000);
                    }

                    // Checkar collisioner med polis
                    Police policeman = police.FirstOrDefault(p => p.X == thief.X && p.Y == thief.Y);
                    if (policeman != null && thief.StolenItems != null)
                    {
                        // Fångar tjuven
                        Console.WriteLine("A thief has been caught by a policeman and lost the stolen item!");
                        thief.StolenItems = null;
                        caughtThieves++;
                        // Pausa i 2 sek
                        Thread.Sleep(2000);
                    }

                    map.PlaceEntity(thief);
                }
                map.Render();

                // Antalet robberies samt antalet fågna tjuvar
                Console.WriteLine($"Robberies: {successfulRobberies} | Thieves Caught: {caughtThieves}");

                // Tickrate
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
