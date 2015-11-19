using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    public interface SortAlgorithm
    {
        List<int> sort(ProblemToAlgorithm data);
        Dictionary<String, String> getParams();
        void updateParam(String pName, String pVal);
        void setNumberSwapListener(Interfaces.NumberSwapListener n);
        String getName();
    }
}
