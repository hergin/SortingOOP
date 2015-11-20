using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingVisualiser:Interfaces.NumberSwapListener
    {

        int[] theList;

        public SortingVisualiser(List<int> list)
        {
            theList = list.ToArray();
            Console.WriteLine("Original List:");
            printList();
        }

        private void printList()
        {
            Console.WriteLine(string.Join(",", theList));
        }

        public void onNumberSwapped(int x, int y)
        {
            Console.WriteLine("Swapping ["+x+"] with ["+y+"]:");
            int temp = theList[x];
            theList[x] = theList[y];
            theList[y] = temp;
            printList();
        }
    }
}
