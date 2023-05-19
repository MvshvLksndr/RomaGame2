using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roma
{
    internal class Player
    {
        public List<int> dices { get; set; }

        public Player() 
        { 
            dices = new List<int>();
        }
    }
}
