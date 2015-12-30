using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class GradingProblem : Problem
    {

        List<Tuple<String, int>> studentRoster = new List<Tuple<string, int>>();

        public GradingProblem()
        {
            studentRoster.Add(new Tuple<string, int>("Ali", 20));
            studentRoster.Add(new Tuple<string, int>("Ahmet", 30));
            studentRoster.Add(new Tuple<string, int>("Ayse", 22));
            studentRoster.Add(new Tuple<string, int>("Mert", 55));
            studentRoster.Add(new Tuple<string, int>("Meliha", 10));
        }

        public ProblemToAlgorithm getDataForAlgorithm()
        {
            return new ProblemToAlgorithm(studentRoster);
        }

        public string getDesc()
        {
            return "This problem sorts the students grades in some order!";
        }

        public string getName()
        {
            return "Grading Students";
        }
    }
}
