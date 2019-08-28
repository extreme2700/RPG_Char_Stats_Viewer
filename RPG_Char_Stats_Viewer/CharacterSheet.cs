using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Char_Stats_Viewer
{
    public class CharacterSheet
    {
        public string name; 
        public string race;
        public int level;

        // create a contructor so some intial values can be given
        public CharacterSheet()
        {
            name = "Ragnar";
            race = "Dwarf";
            level = 1;
        }
    }
}
