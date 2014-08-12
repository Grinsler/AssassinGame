using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssassinGame.Sceens
{
    public class DrugLord
    {
        
        string ConsoleSetup = "";
        string ConsoleChoice1 = "";
        string ConsoleChoice2 = "";
        string ConsoleChoice3 = "";

        string[] PossibleChoices = new string[4];

        public string Property_ConsoleSetup
        {
            get
            {
                return ConsoleSetup;
            }
            set
            {
                ConsoleSetup = value;
            }
        }
        public string Property_ConsoleChoice1
        {
            get
            {
                return ConsoleChoice1;
            }
            set
            {
                ConsoleChoice1 = value;
            }
        }
        public string Property_ConsoleChoice2
        {
            get
            {
                return ConsoleChoice2;
            }
            set
            {
                ConsoleChoice2 = value;
            }
        }
        public string Property_ConsoleChoice2
        {
            get
            {
                return ConsoleChoice2;
            }
            set
            {
                ConsoleChoice2 = value;
            }
        }
        public string[] Property_PossibleChoices
        {
            get
            {
                return PossibleChoices;
            }
            private set
            {
                PossibleChoices = value;
            }
        }
        
        
        public string[] LeavingNeumont()
        {
            ConsoleSetup = "You leave HQ through a back enterance, You decide that you can save time by jumping over the dumpster and crossing the construction field. Or take the easy route, and go through the alley, where you notice a shady fellow.";
            ConsoleChoice1 = "You decide to a risk, and jump over the dumpster";
            ConsoleChoice2 = "Play it somwhat safe, and take the alley";
            ConsoleChoice3 = "You're an assassin, and you just spoted a possible intruder - kill him";

            PossibleChoices[0] = ConsoleSetup;
            PossibleChoices[1] = ConsoleChoice1;
            PossibleChoices[2] = ConsoleChoice2;
            PossibleChoices[3] = ConsoleChoice3;
            
            return PossibleChoices;
        }
    }
}
