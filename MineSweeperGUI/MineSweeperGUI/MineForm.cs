using System;
using MineSweeperGUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeperModel;
using System.Diagnostics;

namespace MineSweeperGUI
{
    public partial class MineForm : Form
    {
        public static int clicks = 0;
        private Stopwatch watch = new Stopwatch();
        private int timerInterval = 100;
        public static int difficulty = Form1.numofbombs;
        public static int boardSize = Form1.boardsize;

        static Board myBoard = new Board(Form1.boardsize);


        private myButton[,] btnGrid = new myButton[myBoard.Size, myBoard.Size];
        public int counter = 0;

        public MineForm()
        {
            InitializeComponent();
            myBoard = new Board(Form1.boardsize);
            myBoard.setUpLiveNeighbors(difficulty);
            myBoard.calculateLiveNeighbors();
            populateGrid();
            timer1.Interval = timerInterval;
        }

        public void printBoard(Board myBoard)
        {
            for (int i = 0; i < myBoard.Size; i++)
            {

                for (int j = 0; j < myBoard.Size; j++)
                {


                    Cell c = myBoard.theGrid[i, j];

                    if (c.cellVisited == true)
                    {
                        if (c.closebomb == 0)
                        {
                            
                            btnGrid[i, j].BackColor = Color.DimGray;
                        }
                        else
                        {
                            btnGrid[i, j].Text = myBoard.theGrid[i, j].closebomb.ToString();
                        }
                    }

                    else
                    {
                        btnGrid[i, j].Text = "";
                    }



                }


            }
            
        }
        private void populateGrid()
        {


            int BtnSize = panel1.Width / myBoard.Size;

            panel1.Height = panel1.Width;

            //nested loops
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new myButton(i,j);
                    btnGrid[i, j].Height = BtnSize;
                    btnGrid[i, j].Width = BtnSize;

                    //add click event to each button.
                    btnGrid[i, j].MouseUp += Grid_Button_Click;

                    //add new button to the panel
                    panel1.Controls.Add(btnGrid[i, j]);

                    // set location of the new button.
                    btnGrid[i, j].Location = new Point(i * BtnSize, j * BtnSize);

                   //btnGrid[i, j].Text = "";
                   // btnGrid[i, j].Tag = new Point(i, j);
                }
            }




        }


 
        private void Grid_Button_Click(object sender, MouseEventArgs e)
        {
            clicks++;
            lbl_score.Text = clicks.ToString();
            if (clicks == 1)
            {
                watch.Start();
                timer1.Enabled = true;
            }
  
            myButton clickedButton = (myButton)sender;

            if (e.Button == MouseButtons.Right)
            {
                if (myBoard.theGrid[clickedButton.row, clickedButton.col].isFlagged == true)
                {
                    btnGrid[clickedButton.row, clickedButton.col].BackgroundImage = null;
                    myBoard.theGrid[clickedButton.row, clickedButton.col].isFlagged = false;
                }
                else if(myBoard.theGrid[clickedButton.row, clickedButton.col].cellVisited == false)
                {
                    btnGrid[clickedButton.row, clickedButton.col].BackgroundImage = Properties.Resources.flag;
                    btnGrid[clickedButton.row, clickedButton.col].BackgroundImageLayout = ImageLayout.Stretch;

                    myBoard.theGrid[clickedButton.row, clickedButton.col].isFlagged = true;
                }
            }
            else if(myBoard.theGrid[clickedButton.row, clickedButton.col].isFlagged == false)
            {
                

                //Point location = (Point)clickedButton.Tag;

               // int x = location.X;
                //int y = location.Y;

                myBoard.floodFill(clickedButton.row, clickedButton.col);

                printBoard(myBoard);

                if (myBoard.theGrid[clickedButton.row, clickedButton.col].cellLive)
                {
                    btnGrid[clickedButton.row, clickedButton.col].BackgroundImage = Properties.Resources.bomb;
                    btnGrid[clickedButton.row, clickedButton.col].BackgroundImageLayout = ImageLayout.Stretch;
                    Lost();
                    MessageBox.Show("You Lose! Would you like to retry?");
                    Form1 retry = new Form1();
                    retry.Show();
                    retry.Location = this.Location;
                    this.Dispose(false);
                }

                if (myBoard.continueGame())
                {
                    watch.Stop();
                    timeRecord = timeTracker.Text;
                    MessageBox.Show("Congratulations! You won!");
                    NameEntry retry = new NameEntry(clicks, boardSize);
                    retry.Show();
                    retry.Location = this.Location;
                    this.Dispose(false);
                }
            }


        }

        public void Lost()
        {
            for (int row = 0; row < myBoard.Size; row++)
            {
                for (int col = 0; col < myBoard.Size; col++)
                {
                    if(myBoard.theGrid[row, col].cellLive == true)
                        {
                        btnGrid[row, col].BackgroundImage = Properties.Resources.bomb;
                        btnGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            timeTracker.Text = ts.ToString("mm\\:ss\\:ff");
        }

        public String timeRecord;
    }
}
