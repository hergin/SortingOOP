using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    /*
        I had to make this a class, since C# doesn't
        let anonymous classes to implement an interface,
        furthermore it doesn't let anonymous classes.
    */
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
