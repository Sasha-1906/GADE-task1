using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_H
{
    class GameEngine
    {
        Map maparoo;
        bool isGameOver = false;
        string winningFaction = "";
        int round = 0;

        public GameEngine()
        {
            maparoo = new Map(10);
        }

        public bool IsGameOver
        {
            get { return isGameOver; }
        }

        public string WinningFaction
        {
            get { return winningFaction; }
        }

        public int Round
        {
            get { return round; }
        }

        public string GetMapDisplay()
        {
            return maparoo.GetMapDisplay();
        }

        public string GetUnitInfo()
        {
            string unitInfo = "";
            for (int i = 0; i < maparoo.Units.Length; i++)
            {
                unitInfo += maparoo.Units[i] + "\n";
            }
            return unitInfo;
        }

        public void Reset()
        {
            maparoo.Reset();
            isGameOver = false;
            round = 0;
        }

        public void GameLoop()
        {
            for (int i = 0; i < maparoo.Units.Length; i++)
            {
                if (maparoo.Units[i].IsDestroyed)
                {
                    continue;
                }

                Unit closestUnit = maparoo.Units[i].GetClosestUnit(maparoo.Units);
                if (closestUnit == null)
                {
                    isGameOver = true;
                    winningFaction = maparoo.Units[i].Faction;
                    maparoo.UpdateMap();
                    return;
                }

                double healthPercentage = maparoo.Units[i].Health / maparoo.Units[i].MaxHealth;
                if (healthPercentage <= 0.25)
                {
                    maparoo.Units[i].RunAway();
                }
                else if (maparoo.Units[i].IsInRange(closestUnit))
                {
                    maparoo.Units[i].Attack(closestUnit);
                }
                else
                {
                    maparoo.Units[i].Move(closestUnit);
                }
                StayInBounds(maparoo.Units[i], maparoo.Size);
            }

            maparoo.UpdateMap();
            round++;
        }

        private void StayInBounds(Unit unit, int size)//moves units that moved off te map back onto the map
        {
            if (unit.X < 0)//if out of the map on the left then move to the first left collum
            {
                unit.X = 0;
            }
            else if (unit.X >= size)// on the right
            {
                unit.X = size - 1;
            }

            if (unit.Y < 0)// to the top
            {
                unit.Y = 0;
            }
            else if (unit.Y >= size)//to the bottom
            {
                unit.Y = size - 1;
            }
        }
    }
}
