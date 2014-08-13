using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AssassinGame.Sceens
{
    public class Mission
    { 
        public string Property_Choice1 { get; private set; }
        public string Property_Choice2 { get; private set; }
        public string Property_Choice3 { get; private set; }
        public string Property_Setup { get; private set; }

        public int Interaction(string[] Choices)
        {
            int userchoice = 0;

            Property_Setup = Choices[0];
            Property_Choice1 = Choices[1];
            Property_Choice2 = Choices[2];
            Property_Choice3 = Choices[3];

            return 1;
        }
    }
}
