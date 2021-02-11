using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGUI
{
    class Score
    {
        String score { get; set; }
        String name { get; set; }

        public Score(String score, String name)
        {
            this.score = score;
            this.name = name;
        }

        public Score()
        { }

        public override string ToString()
        {
            return name + " - " + score;
        }
    }
}
