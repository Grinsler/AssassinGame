﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssassinGame.AssassinControls;
using AssassinGame.Models;

namespace AssassinGame.Sceens
{
    public class Mission_DrugLord
    {
        
        Player Player = new Player();
        MissionControl mc = new MissionControl();

        public Mission_DrugLord(Player p)
        {
            Player = p;
            mc.UserChoice = 0;
            mc.MissionDialog("dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue");
            mc.MissionDialog("dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue dialogue");

            mc.MissionDialog("Choose 1 of the following", "jump", "confront", "sweettalk");
        }
        
        
    }
}
