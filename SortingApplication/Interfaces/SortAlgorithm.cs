using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    public interface SortAlgorithm
    {
        List<int> sort(List<int> theList);
        Dictionary<String, String> getParams();
        void updateParam(String pName, String pVal);
        String getName();
    }
}
