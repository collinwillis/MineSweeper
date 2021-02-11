using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    class myButton: Button
    {
        public int row { get; set; }
        public int col { get; set; }

        public myButton(int r, int c)
        {
            row = r;
            col = c;
        }
    }
}
