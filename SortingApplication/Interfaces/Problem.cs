using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    public interface Problem
    {
        String getName();
        String getDesc();
        List<int> getDataForAlgorithm();
    }
}
