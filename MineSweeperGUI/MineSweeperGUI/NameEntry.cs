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
    public partial class NameEntry : Form
    {
        public static String name="";
        public static int boardSize = MineForm.boardSize;
        public static int score = MineForm.clicks;
        public NameEntry(int clicks, int boardSize)
        {
            InitializeComponent();
            label2.Text = clicks.ToString();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            LeaderBoard scores = new LeaderBoard(name, score, boardSize);
            scores.StartPosition = FormStartPosition.Manual;
            scores.Location = this.Location;

            scores.Show();
            this.Dispose(false);
        }
    }
}
