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
            algoParams["Param1"] = new Model.Parameter("Param1", 5, new List<Object>() { 1, 2, 3, 4, 5 }, 3);
            algoParams["Param2"] = new Model.Parameter("Param2", true, new List<Object>() { true, false }, true);
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
