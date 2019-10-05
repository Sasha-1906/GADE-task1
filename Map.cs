using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_1
{
    class Map
    {
        char[,] maparoo = new char[20, 20];//char cause the map has symbols 
        Random rnd = new Random();
        public Unit[] unit;
        static int remaining;

        int rndNum;//a holding place for rnd number

        public Map(int gib)//constructor
        {
            unit = new Unit[gib];
        }

        public void BattlefieldRndGen()
        {

            for (int y = 0; y < 20; y++)//fill map with "grass" - 'w'
            {
                for (int x = 0; x < 20; x++)
                {
                    maparoo[x, y] = 'w';//'' cause char/ "" cause string
                }
            }

            for (int i = 0; i < unit.Length; i++)//this will run the amount of times units has
            {
                rndNum = rnd.Next(0, 2);//either 0 or 1 - 0 = melee and 1 = ranged
                if (rndNum == 0)//if rndNum is 0 then give all melee specs and random gen coor. 
                {
                    MeleeUnit melee = new MeleeUnit();

                    melee.X = rnd.Next(20);
                    melee.Y = rnd.Next(20);

                    if (maparoo[melee.X, melee.Y] == 'w')
                    {
                        maparoo[melee.X, melee.Y] = melee.Symbol;

                        unit[i] = melee;//gives this unit Melee base specific values
                    }
                    else
                    {
                        i = i - 1;
                    }


                    
                    
                    //an if here to make sure 2 units are not placed on the same spot!
                }
                else//if rndNum is 1 then give all range specs and random gen coor. 
                {
                    RangedUnit range = new RangedUnit();

                    range.X = rnd.Next(20);
                    range.Y = rnd.Next(20);//randomises the x and y coor.

                    if (maparoo[range.X, range.Y] == 'w')
                    {
                        unit[i] = range;
                        maparoo[range.X, range.Y] = range.Symbol;//replaces the symbol at the random x and y with the char from ranged('R')
                    }
                    else
                    {
                        i = i - 1;
                    }   
                }
            }
        }

        public void Refresh()
        {
            for (int y = 0; y < 20; y++)//fill map with "grass" - 'w'
            {
                for (int x = 0; x < 20; x++)
                {
                    maparoo[x, y] = 'w';//'' cause char/ "" cause string
                }
            }

            for (int i = 0; i < unit.Length; i++)
            {
                maparoo[unit[i].X, unit[i].Y] = unit[i].Symbol;
            }

        }

        public void PopuLbl(Label lbl)//populates the map across when done moves to the next line and starts again
        {

            lbl.Text = "";//clears whatevers in the lable
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    lbl.Text +=" "+maparoo[x, y]+ " ";
                }
                lbl.Text += "\n";//moves to next new line
            }
        }

        public void PrintInfo(RichTextBox txt)
        {
             txt.Text= "";
            for (int i = 0; i < unit.Length; i++)
            {
                txt.Text += unit[i].ToString() + "\n";
            }
        }

        public void updateVis(int x, int y, Unit u)//when give unit and coor. its updates and moves it 
        {
            maparoo[u.X, u.Y] = 'w';
            u.X = x;
            u.Y = y;
            maparoo[u.X, u.Y] = u.Symbol;
        }

        public bool lastUnit()
        {
            remaining = 15;
            for (int i = 0; i < unit.Length; i++)
            {
                if(unit[i].Health <= 0)
                {
                    remaining--;
                }
            }

            if(remaining > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
