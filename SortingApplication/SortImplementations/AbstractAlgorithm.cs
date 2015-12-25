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
        protected Dictionary<String, Model.Parameter> algoParams = new Dictionary<String, Model.Parameter>();
        protected NumberSwapListener numberSwapListener;

        public abstract string getName();

        public Dictionary<string, Model.Parameter> getParams()
        {
            return algoParams;
        }

        public void setNumberSwapListener(NumberSwapListener n)
        {
            this.numberSwapListener = n;
        }

        public abstract List<int> sort(ProblemToAlgorithm data);

        public void updateParam(string pName, Object pVal)
        {
            algoParams[pName].setValue(pVal);
        }
    }
}
