using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingApplication.Model;

namespace SortingApplication.Interfaces
{
    public interface SortAlgorithm
    {
        void sort(ProblemToAlgorithm data);
        Dictionary<String, Model.Parameter> getParams();
        void updateParam(String pId, Object pVal);
        void setNumberSwapListener(Interfaces.NumberSwapListener n);
        NumberSwapListener getNumberSwapListener();
        String getName();
    }
}
