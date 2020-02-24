using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoie.Interfaces
{
    public interface ITowerOfHanoie
    {
        int TotalNumOfMoves { get; set; }

        void SolveTowerOfHanoi(int n, char startStack, char endStack, char middleStack );
    }
}
