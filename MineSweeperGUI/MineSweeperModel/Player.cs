using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweeperModel
{
        public class Player : IComparable<Player>
        {

            public string nameplayer { get; set; }
            public int score { get; set; }

            public Player(string nameplayer, int score)
            {
                this.nameplayer = nameplayer;
                this.score = score;
            }

            public override string ToString()
            {
                return nameplayer + ", " + score;
            }

            public int CompareTo(Player other)
            {

                int compareScore = this.score.CompareTo(other.score);
                if (compareScore == 0)
                {
                    return this.nameplayer.CompareTo(other.nameplayer);
                }
                return compareScore;


            }
        }
    }

