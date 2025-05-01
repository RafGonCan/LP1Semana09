using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player
    {
        public string Name {get;}
        public int Score {get; set;}

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}