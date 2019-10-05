using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    public abstract class Unit
    {
        protected int x, y, health, maxHealth, speed, attack, attackRange, faction, index;
        protected char symbol;
        protected bool isAttacking;


        public abstract void Move(Unit[] unitAr);
        public abstract void Combat(Unit[] unitAr);
        public abstract bool AttackRangeCheck(Unit[] unitAr);
        public abstract void UnitPosition(Unit[] unitAr);
        public abstract void UnitDeath();
        public abstract string ToString();

        public Unit(int x, int y, int health, int speed,int attack,int attackRange, int faction, char symbol, bool isAttacking)
        {
            this.x =x;
            this.y =y;
            this.health =health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol =symbol;
            this.isAttacking = isAttacking;
            this.index = 0;
        }

        public abstract int X { get; set; }

        public abstract int Y { get; set; }

        public abstract int Health { get; set; }

        public abstract int MaxHealth { get;}

        public abstract int Speed { get; set; }

        public abstract int Attack { get; set; }

        public abstract int AttackRange { get; set; }

        public abstract int Faction { get; set; }

        public abstract char Symbol { get; set; }

        public abstract bool IsAttacking { get; set; }

        public abstract int Index { get; set; }

    }

 
}
