using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class MergeSort : SortAlgorithm
    {

        Dictionary<String, String> algoParams = new Dictionary<String, String>();

        public MergeSort()
        {
            algoParams["Param1"] = "5";
            algoParams["Param2"] = "paramVal";
        }

        public string getName()
        {
            return "Merge Sort";
        }

        public Dictionary<String, String> getParams()
        {
            return algoParams;
        }

        public List<int> sort(ProblemToAlgorithm data)
        {
            int[] arrayEquivalent = data.getData().ToArray<int>();
            Array.Sort(arrayEquivalent);
            return new List<int>(arrayEquivalent);
        }

        public void updateParam(string pName, string pVal)
        {
            algoParams[pName] = pVal;
        }
    }
}
