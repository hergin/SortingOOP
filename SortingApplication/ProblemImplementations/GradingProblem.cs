using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class GradingProblem : Problem
    {

        Dictionary<String, int> studentRoster = new Dictionary<string, int>();

        public GradingProblem()
        {
            studentRoster.Add("Ali", 20);
            studentRoster.Add("Ahmet", 30);
            studentRoster.Add("Ayse", 22);
            studentRoster.Add("Mert", 55);
            studentRoster.Add("Meliha", 10);
        }

        public List<int> getDataForAlgorithm()
        {
            return studentRoster.Values.ToList<int>();
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
