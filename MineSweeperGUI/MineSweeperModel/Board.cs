using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweeperModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public int difficultyPercentage{ get; set; }

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }


        public bool isSafe(int x, int y)
        {
            if (x < 0 || x >= Size || y < 0 || y >= Size)
            {
                return false;
            }
            else
                return true;
        }



        public void setUpLiveNeighbors(int bombs)
        {
            int xCoord = 0;
            int yCoord = 0;
            Random randomNumber = new Random();
         
            int placement = 0;
            int numberOfNewBombs = Size * Size * difficultyPercentage / 100;
            Board myBoard = new Board(8);

            

            while (placement < bombs)
            {
                xCoord = randomNumber.Next(Size);
                yCoord = randomNumber.Next(Size);
                if (theGrid[xCoord, yCoord].cellLive == true)
                {

                }
                else
                {
          
                    theGrid[xCoord, yCoord].cellLive = true;

                    placement++;
                }
                

            }

  

        }
        //public int counter { get; set; }
        public void calculateLiveNeighbors()
        {


            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Cell c = theGrid[i,j];

                    if (isSafe(i + 1, j) && theGrid[i + 1, j].cellLive) c.closebomb++;
                    if (isSafe(i + 1, j + 1) && theGrid[i + 1, j + 1].cellLive) c.closebomb++;
                    if (isSafe(i + 1, j - 1) && theGrid[i + 1, j - 1].cellLive) c.closebomb++;
                    if (isSafe(i - 1, j) && theGrid[i - 1, j].cellLive) c.closebomb++;
                    if (isSafe(i - 1, j + 1) && theGrid[i - 1, j + 1].cellLive) c.closebomb++;
                    if (isSafe(i - 1, j - 1) && theGrid[i - 1, j - 1].cellLive) c.closebomb++;
                    if (isSafe(i, j + 1) && theGrid[i, j + 1].cellLive) c.closebomb++;
                    if (isSafe(i, j - 1) && theGrid[i, j - 1].cellLive) c.closebomb++;

                }
            }

        }

        public void floodFill(int row, int col)
        {

            
                theGrid[row, col].cellVisited = true;
            
             if (theGrid[row, col].closebomb == 0 && isSafe(row, col) == true)
            {

                if (isSafe(row + 1, col) && theGrid[row + 1, col].cellVisited == false)
                {
                    floodFill(row + 1, col);
                }

                if (isSafe(row - 1, col) && theGrid[row - 1, col].cellVisited == false)
                {
                    floodFill(row - 1, col);
                }
                if (isSafe(row + 1, col + 1) && theGrid[row + 1, col + 1].cellVisited == false)
                {
                    floodFill(row + 1, col + 1);
                }

                if (isSafe(row, col + 1) && theGrid[row, col + 1].cellVisited == false)
                {
                    floodFill(row, col + 1);
                }
                if (isSafe(row, col - 1) && theGrid[row, col - 1].cellVisited == false)
                {
                    floodFill(row, col - 1);
                }
                if (isSafe(row - 1, col - 1) && theGrid[row - 1, col - 1].cellVisited == false)
                {
                    floodFill(row - 1, col - 1);
                }
                if (isSafe(row + 1, col - 1) && theGrid[row + 1, col - 1].cellVisited == false)
                {
                    floodFill(row + 1, col - 1);
                }
                if (isSafe(row - 1, col + 1) && theGrid[row - 1, col + 1].cellVisited == false)
                {
                    floodFill(row - 1, col + 1);
                }

            }
        }

        public bool continueGame()
        {
            bool continueGame = true;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (theGrid[i, j].cellVisited == false && theGrid[i, j].cellLive == false)
                    {
                        continueGame = false;
                    }

                }
            }
            return continueGame;
        }


    }
}
