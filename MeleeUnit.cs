using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    class MeleeUnit: Unit
    {
        public MeleeUnit() : base(0, 0, 50, 1, 10, 1, 1, 'M', false)
        {

        }

        public override void Move(Unit[] unitAr)
        {
            Random rnd = new Random();
            int random;

            if (Health >= maxHealth / 4)
            {
                if (Math.Pow(X - unitAr[Index].X, 2) >= Math.Pow(Y - unitAr[Index].Y, 2))//checks the longest x distance over the y distance and moves in the longer direction
                {
                    if (X - unitAr[Index].X > 0)//move left
                    {
                        X--;
                    }
                    else//move right
                    {
                        X++;
                    }
                }
                else
                {
                    if (Y - unitAr[Index].Y > 0)//move up
                    {
                        Y--;
                    }
                    else//move down
                    {
                        Y++;
                    }
                }
            }
            else
            {
                if (X == 0 && Y == 0)//top left
                {
                    if (rnd.Next(0,2) == 0)
                    {
                        X++;
                    }
                    else
                    {
                        Y++;
                    }
                }
                else if(X == 0 && Y == 19)//BOTTOM LEFT
                {
                    if (rnd.Next(0, 2) == 1)
                    {
                        X++;
                    }
                    else
                    {
                        Y--;
                    }
                }
                else if(X == 19 && Y == 0)// top right
                {
                    if (rnd.Next(0,2) == 0)
                    {
                        X--;
                    }
                    else
                    {
                        Y++;
                    }
                }
                else if(X == 19 && Y == 19)//BOTTOM RIGHT
                {
                    if (rnd.Next(0,2)== 1)
                    {
                        X--;
                    }
                    else
                    {
                        Y--;
                    }
                }
                else if(X == 0)//left wall
                {
                    random = rnd.Next(0, 3);
                    if (random==0)
                    {
                        Y--;
                    }
                    else if(random == 1)
                    {
                        Y++;
                    }
                    else
                    {
                        X++;
                    }
                }
                else if (X == 19)//right wall
                {
                    random = rnd.Next(0, 3);
                    if (random == 0)
                    {
                        Y--;
                    }
                    else if(random == 1)
                    {
                        Y++;
                    }
                    else
                    {
                        X--;
                    }
                }
                else if (Y == 0)//top wall
                {
                    random = rnd.Next(0, 3);
                    if (random == 0)
                    {
                        X++;
                    }
                    else if (random == 1)
                    {
                        X--;
                    }
                    else
                    {
                        Y++;
                    }
                }
                else if (Y == 19)//bottom wall
                {
                    random = rnd.Next(0, 3);
                    if(random == 0)
                    {
                        X++;
                    }else if (random == 1)
                    {
                        X--;
                    }
                    else
                    {
                        Y--;
                    }
                }
                else//if none of the above
                {
                    random = rnd.Next(0, 4);
                    if (random == 0)
                    {
                        X++;
                    }
                    else if(random == 1)
                    {
                        X--;
                    }
                    else if(random == 2)
                    {
                        Y++;
                    }
                    else
                    {
                        Y--;
                    }
                }
            }
        }

        public override void Combat(Unit[] unitAr)
        {
            IsAttacking = true;

            unitAr[Index].Health -= Attack;//reduses the health of the unit being attacked

            if (unitAr[Index].Health <= 0)
            {
                unitAr[Index].UnitDeath();
            }
        }

        public override bool AttackRangeCheck(Unit[] unitAr)//if in range check, used in combat
        {
            double distance = Math.Sqrt(Math.Pow(X - unitAr[Index].X, 2) + Math.Pow(Y - unitAr[Index].Y, 2));

            if(distance< AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void UnitPosition(Unit[] unitAr)//finds unit closest to this unit in the array given
        {
            double distance = 50, tempDis;
            for (int i = 0; i < unitAr.Length; i++)
            {
                if(unitAr[i].Health > 0)
                {
                    tempDis = Math.Sqrt(Math.Pow(X - unitAr[i].X, 2) + Math.Pow(Y - unitAr[i].Y, 2));
                    if (this != unitAr[i])
                    {
                        if (tempDis < distance)
                        {
                            distance = tempDis;
                            Index = i;//this going to remember index of closest unit in array
                        }
                    }
                }
            }
        }

        public override void UnitDeath()
        {
            Symbol = 'w';
            
        }
        public override string ToString()
        {
            if(Health > 0)
            {
                return ("The x and y positions are: " + x + y + "respectively. \nHealth is " + health + ". \nSpood is" + speed + ". \nAttack is " + attack + " and attack range " + attackRange + ". \nFaction number " + faction + " and symbol is " + symbol + ".");

            }
            else
            {
                return "";
            }
        }

        public override int X
        {
            get { return x; }
            set { x = value; }
        }
        public override int Y
        {
            get { return y; }
            set { y = value; }
        }
        public override int Health
        {
            get { return health; }
            set { health = value; }
        }
        public override int MaxHealth
        {
            get { return maxHealth; }
        }
        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public override int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public override int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public override int Faction
        {
            get { return faction; }
            set { faction = value; }
        }
        public override char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
 
        }
        public override bool IsAttacking
        {
            get { return isAttacking; }
            set { isAttacking = value; }
        }
        public override int Index
        {
            get { return index; }
            set { index = value; }
        }

    }
}
