using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingApplication.Interfaces;

namespace SortingApplication.SortImplementations
{
    abstract class AbstractAlgorithm : Interfaces.SortAlgorithm
    {
        protected Dictionary<String, String> algoParams = new Dictionary<String, String>();
        protected NumberSwapListener numberSwapListener;

        public abstract string getName();

        public Dictionary<string, string> getParams()
        {
            return algoParams;
        }

        public void setNumberSwapListener(NumberSwapListener n)
        {
            this.numberSwapListener = n;
        }

        public abstract List<int> sort(ProblemToAlgorithm data);

        public void updateParam(string pName, string pVal)
        {
            algoParams[pName] = pVal;
        }
    }
}
