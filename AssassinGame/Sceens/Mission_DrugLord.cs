using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssassinGame.AssassinControls;
using AssassinGame.Models;
using System.Windows.Threading;

namespace AssassinGame.Sceens
{
    public class Mission_DrugLord
    {
        private DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        Player Player = new Player();
        MissionControl mc = new MissionControl();

        public Mission_DrugLord(Player p)
        {
            Player = p;
            mc.UserChoice = 0;
            mc.MissionDialog("dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue");
            
            timer.Start();
            timer.Tick += new EventHandler(timerCheck);

            mc.MissionDialog("dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue");

            if (Player.Player_Charisma > 3)
            {
                mc.MissionDialog("Choose 1 of the following", "jump", "confront", "sweettalk");
            }
            else
                mc.MissionDialog("Choose 1 of the following", "jump", "confront");
        }

        private void timerCheck(object sender, EventArgs e)
        {
            if (mc.UserChoice != 0)
            {
                timer.Stop();
            }
        }
        
    }
}
