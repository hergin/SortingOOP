using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class QuickSort : SortImplementations.AbstractAlgorithm
    {
   
        public QuickSort()
        {
            algoParams["Pivot"] = "middle";
            algoParams["Speed"] = "bla bla";
            algoParams["greeting"] = "hello";
            algoParams["mac value"] = "33";
        }

        public override string getName()
        {
            return "Quick Sort";
        }
        

        public override List<int> sort(ProblemToAlgorithm data)
        {
            int[] arrayEquivalent = data.getData().ToArray<int>();
            Array.Sort(arrayEquivalent);
            return new List<int>(arrayEquivalent);
        }
        
    }
}
