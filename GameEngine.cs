using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    class GameEngine
    {
        public int roundCount=0;

        public void Round(Unit[] unitAr)
        {
            roundCount++;
            for (int i = 0; i < unitAr.Length; i++)
            {
                unitAr[i].UnitPosition(unitAr);//got target
                
                if (unitAr[i].Health >= unitAr[i].MaxHealth / 4 && unitAr[i].AttackRangeCheck(unitAr))//checked if its in range and above a quarter health
                {
                    unitAr[i].Combat(unitAr);//attack
                }
                else
                {
                    unitAr[i].Move(unitAr);
                }
            }
        }
    }
}
