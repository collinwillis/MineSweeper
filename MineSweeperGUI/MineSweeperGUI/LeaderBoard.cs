using MineSweeperModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//LeaderBoard by Collin Willis and Adrian Rodriguez

namespace MineSweeperGUI
{
    public partial class LeaderBoard : Form
    {

        private List<Player> myplayer = new List<Player>();
        private List<Player> myplayer2 = new List<Player>();
        private List<Player> myplayer3 = new List<Player>();
        public static string namep = NameEntry.name;




        BindingSource playerinv = new BindingSource();
        BindingSource playerinv2 = new BindingSource();
        BindingSource playerinv3 = new BindingSource();


        //File paths to player text files.
        private string path = @"C:\demo\players.txt";
        private string path2 = @"C:\demo\players2.txt";
        private string path3 = @"C:\demo\players3.txt";



        public LeaderBoard(string name, int score, int boardSize)
        {
            InitializeComponent();


            using (var fileSStream = File.Open(path, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileSStream))
                {

               
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null) break;

                        string[] items = line.Split(',');
                        Player p1 = new Player(items[0], int.Parse(items[1]));
                        myplayer.Add(p1);
                    }
                }
                fileSStream.Close();
            }



            using (var fileSStream2 = File.Open(path2, FileMode.Open))
            {
                using (StreamReader reader2 = new StreamReader(fileSStream2))
                {

                    // one
                    while (true)
                    {
                        string line2 = reader2.ReadLine();
                        if (line2 == null) break;

                        string[] items2 = line2.Split(',');
                        Player p2 = new Player(items2[0], int.Parse(items2[1]));
                        myplayer2.Add(p2);
                    }
                }
                fileSStream2.Close();
            }

            using (var fileSStream3 = File.Open(path3, FileMode.Open))
            {
                using (StreamReader reader3 = new StreamReader(fileSStream3))
                {

                    // one
                    while (true)
                    {
                        string line3 = reader3.ReadLine();
                        if (line3 == null) break;

                        string[] items3 = line3.Split(',');
                        Player p3 = new Player(items3[0], int.Parse(items3[1]));
                        myplayer3.Add(p3);
                    }
                }
                fileSStream3.Close();
            }


            if (boardSize == 8)
            {
                Player p = new Player(name, score);
                myplayer.Add(p);
            }
            if (boardSize == 10)
            {
                
                Player p2 = new Player(name, score);
                myplayer2.Add(p2);
            }
            if (boardSize == 16)
            {
               
                Player p3 = new Player(name, score);
                myplayer3.Add(p3);
            }

            // sorts scores
            myplayer.Sort();
            myplayer2.Sort();
            myplayer3.Sort();


            if (boardSize == 8)
            {
                List<string> outContents = new List<string>();

                foreach (Player p1 in myplayer)
                {
                    outContents.Add(p1.ToString());
                }

                string outFile = path;
                File.WriteAllLines(outFile, outContents);
            }
            if (boardSize == 10)
            {
                List<string> outContents = new List<string>();

                foreach (Player p2 in myplayer2)
                {
                    outContents.Add(p2.ToString());
                }

                string outFile = path2;
                File.WriteAllLines(outFile, outContents);
            }
            if (boardSize == 16)
            {
                List<string> outContents = new List<string>();

                foreach (Player p3 in myplayer3)
                {
                    outContents.Add(p3.ToString());
                }

                string outFile = path3;
                File.WriteAllLines(outFile, outContents);
            }

            // display in listview

            playerinv.DataSource = myplayer;
            lst_easy.DataSource = playerinv;

            playerinv2.DataSource = myplayer2;
            lst_medium.DataSource = playerinv2;

            playerinv3.DataSource = myplayer3;
            lst_hard.DataSource = playerinv3;

            playerinv.ResetBindings(false);
            playerinv2.ResetBindings(false);
            playerinv3.ResetBindings(false);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.Location = this.Location;
            newGame.Show();
            this.Dispose(false);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
