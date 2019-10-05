using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace PROJECT_1
{
    public partial class frmGameEngine : Form
    {
        Map map = new Map(15);
        GameEngine gameEngine = new GameEngine();
        Timer timer = new Timer();

        public frmGameEngine()
        {
            InitializeComponent();
            DoAgain();
        }

        public void DoAgain ()
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Round);
        }

        public void Round(Object sender, System.EventArgs e)
        {
            gameEngine.Round(map.unit);
            map.Refresh();
            lblGameRound.Text = "Round: " + gameEngine.roundCount;
            map.PopuLbl(lblGameMap);
            map.PrintInfo(txtUnitUpdate);

            if(map.lastUnit())
            {
                timer.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            map.BattlefieldRndGen();
            map.PopuLbl(lblGameMap);

            timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
