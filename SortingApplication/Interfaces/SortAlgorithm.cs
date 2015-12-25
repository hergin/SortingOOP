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
        List<int> sort(ProblemToAlgorithm data);
        Dictionary<String, Model.Parameter> getParams();
        void updateParam(String pId, Object pVal);
        void setNumberSwapListener(Interfaces.NumberSwapListener n);
        String getName();
    }
}
