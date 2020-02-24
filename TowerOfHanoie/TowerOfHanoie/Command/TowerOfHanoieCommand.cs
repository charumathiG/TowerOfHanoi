using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoie.Interfaces;

namespace TowerOfHanoie.Command
{
    
    public class TowerOfHanoieCommand : ITowerOfHanoie
    {
        public int TotalNumOfMoves { get; set; }
        

        public void SolveTowerOfHanoi(int n, char startStack, char endStack,char middleStack)
        {
            if (n <= 0)
            {
                //Console.WriteLine("Move disk 1 startStack " + startStack + " endStack " + endStack);
                return;
            }
            else
            {
                SolveTowerOfHanoi(n - 1, startStack, middleStack, endStack);
                Console.WriteLine("Move disk " + n + " startStack " + startStack + " endStack " + endStack);
                SolveTowerOfHanoi(n - 1, middleStack, endStack, startStack);
            }
            TotalNumOfMoves= (int)(Math.Pow(2, n) - 1);
        }
        public static void Main(string[] args)
        {
            TowerOfHanoieCommand program = new TowerOfHanoieCommand();
            Console.WriteLine("Enter the number of disk");
            int disk = Convert.ToInt16(Console.ReadLine());
            program.SolveTowerOfHanoi(disk, 'A', 'C', 'B');
            Console.WriteLine("Total Number of  Moves"+"" +program.TotalNumOfMoves);
            Console.ReadKey();
        }
 
    }
}

       