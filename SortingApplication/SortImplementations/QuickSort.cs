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

        public List<int> sort(List<int> theList)
        {
            int[] arrayEquivalent = theList.ToArray<int>();
            Array.Sort(arrayEquivalent);
            return new List<int>(arrayEquivalent);
        }

        public void updateParam(string pName, string pVal)
        {
            algoParams[pName] = pVal;
        }
    }
}
