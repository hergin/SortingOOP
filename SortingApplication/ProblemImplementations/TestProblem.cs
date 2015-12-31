using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingApplication.Interfaces;

namespace SortingApplication.ProblemImplementations
{
    class TestProblem : Problem
    {

        List<Tuple<String, int>> theList = new List<Tuple<string, int>>();

        public TestProblem()
        {
            int listElements = new Random().Next(10);
            for (int i = 0; i < listElements; i++) 
            {
                theList.Add(new Tuple<string, int>("", new Random((int)System.Diagnostics.Stopwatch.GetTimestamp()).Next(0, 200)));
            }
        }

        public ProblemToAlgorithm getDataForAlgorithm()
        {
            return new ProblemToAlgorithm(theList);
        }

        public string getDesc()
        {
            return "Test problem has random numbers in it";
        }

        public string getName()
        {
            return "Test problem";
        }
    }
}
