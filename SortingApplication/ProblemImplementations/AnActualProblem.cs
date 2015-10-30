using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class AnActualProblem : Problem
    {
        public ProblemToAlgorithm getDataForAlgorithm()
        {
            List<int> newList = new List<int>();
            newList.Add(15);
            newList.Add(5);
            newList.Add(20);
            newList.Add(1);
            newList.Add(2);
            newList.Add(6);
            newList.Add(33);
            return new ProblemToAlgorithm(newList);
        }

        public string getDesc()
        {
            return "An example of an actual problem description";
        }

        public string getName()
        {
            return "An Actual problem";
        }
    }
}
