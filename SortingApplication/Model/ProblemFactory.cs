using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingApplication.Interfaces;
using SortingApplication.ProblemImplementations;

namespace SortingApplication.Model
{
    public class ProblemFactory
    {

        public static Problem createActualProblem()
        {
            return new AnActualProblem();
        }

        public static Problem createGradingProblem()
        {
            return new GradingProblem();
        }

        public static Problem createTestProblem()
        {
            return new TestProblem();
        }

    }
}
