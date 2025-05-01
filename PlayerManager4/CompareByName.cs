using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (x == null || y == null) return 0;

            int result = string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);

            return ascending ? result : -result;
        }
    }
}