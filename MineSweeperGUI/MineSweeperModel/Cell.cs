using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweeperModel
{
   public class Cell
    {
        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public bool cellVisited { get; set; }

        public bool cellLive { get; set; }
        public int closebomb { get; set; }

        public bool isFlagged { get; set; }


        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}
