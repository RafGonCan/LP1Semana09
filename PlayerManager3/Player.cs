using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string Name {get;}
        public int Score {get; set;}

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            if (other == null) return -1;

            int result = other.Score.CompareTo(this.Score);
            if (result != 0)
            {
                return result;
            }

            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name} - {Score}";
        }
    }
}