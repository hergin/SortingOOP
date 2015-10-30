using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    public class ProblemToAlgorithm
    {
        List<int> data;

        public ProblemToAlgorithm()
        {
            data = new List<int>();
        }

        public ProblemToAlgorithm(List<int> l)
        {
            data = l;
        }

        public List<int> getData()
        {
            return data;
        }
    }
}
