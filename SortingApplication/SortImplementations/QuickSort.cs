using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class QuickSort : SortAlgorithm
    {
        Dictionary<String, String> algoParams = new Dictionary<String, String>();
        NumberSwapListener numberSwapListener;

        public QuickSort()
        {
            algoParams["Pivot"] = "middle";
            algoParams["Speed"] = "bla bla";
            algoParams["greeting"] = "hello";
            algoParams["mac value"] = "33";
        }

        public string getName()
        {
            return "Quick Sort";
        }

        public Dictionary<string, string> getParams()
        {
            return algoParams;
        }

        public void setNumberSwapListener(NumberSwapListener n)
        {
            numberSwapListener = n;
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
