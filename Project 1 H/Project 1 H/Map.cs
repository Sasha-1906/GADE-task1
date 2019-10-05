using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_H
{
    class Map
    {
        int mapSize = 20;
        Random rnd = new Random();
        int numUnits;
        Unit[] units;
        string[,] maparoo;
        string[] factions = { "Blue-T", "Orange-T" };

        public Map(int numUnits)
        {
            this.numUnits = numUnits;
            Reset();
        }

        public Unit[] Units
        {
            get { return units; }
        }
        public int Size
        {
            get { return mapSize; }
        }

        public string GetMapDisplay()
        {
            string mapString = "";
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    mapString += maparoo[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }

        public void Reset()
        {
            maparoo = new string[mapSize, mapSize];
            units = new Unit[numUnits];
            InitializeUnits();
            UpdateMap();
        }

        public void UpdateMap()
        {
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    maparoo[x, y] = " ~ ";//populates map with ~
                }
            }

            for (int i = 0; i < units.Length; i++)
            {
                maparoo[units[i].X, units[i].Y] = units[i].Faction[0] + "/" + units[i].Symbol;
            }
        }

        private void InitializeUnits()//makes random units
        {
            for (int i = 0; i < units.Length; i++)
            {
                int x = rnd.Next(0, mapSize);
                int y = rnd.Next(0, mapSize);
                int factionIndex = rnd.Next(0, 2);
                int unitType = rnd.Next(0, 2);

                while (maparoo[x, y] != null)
                {
                    x = rnd.Next(0, mapSize);
                    y = rnd.Next(0, mapSize);
                }

                if (unitType == 0)
                {
                    units[i] = new MeleeUnit(x, y, factions[factionIndex]);
                }
                else
                {
                    units[i] = new RangedUnit(x, y, factions[factionIndex]);
                }
                maparoo[x, y] = units[i].Faction[0] + "/" + units[i].Symbol;
            }
        }
    }
}
