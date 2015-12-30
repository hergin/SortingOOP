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
        List<Tuple<String, int>> newList = new List<Tuple<string, int>>();

        public AnActualProblem()
        {
            newList.Add(new Tuple<string, int>("", 20));
            newList.Add(new Tuple<string, int>("", 5));
            newList.Add(new Tuple<string, int>("", 7));
            newList.Add(new Tuple<string, int>("", 10));
            newList.Add(new Tuple<string, int>("", 30));
            newList.Add(new Tuple<string, int>("", 60));
            newList.Add(new Tuple<string, int>("", 55));
            newList.Add(new Tuple<string, int>("", 2));
            newList.Add(new Tuple<string, int>("", 13));
        }

        public ProblemToAlgorithm getDataForAlgorithm()
        {
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
