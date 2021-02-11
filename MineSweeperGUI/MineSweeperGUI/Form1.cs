using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
 
    public partial class Form1 : Form
    {

        public static int boardsize = 0;
        public static int numofbombs = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Btn_start_Click(object sender, EventArgs e)
        {
            if (rdeo_easy.Checked == true)
            {
                numofbombs = 1;
                boardsize = 8;
                MineForm easyform = new MineForm();
                easyform.Show();
                easyform.Location = this.Location;
                this.Dispose(false);

            }
            if (rdeo_medium.Checked == true)
            {
                numofbombs = 30;
                boardsize = 10;
                MineForm easyform = new MineForm();
                easyform.Show();
                easyform.Location = this.Location;
                this.Dispose(false);
            }
            if (rdeo_hard.Checked == true)
            {
                numofbombs =10;
                boardsize = 16;

                MineForm easyform = new MineForm();
                easyform.Show();
                easyform.Location = this.Location;
                this.Dispose(false);
            }
        }
    }
}
