using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApplication
{
    static class ProjectMain
    {
        [STAThread]
        static void Main()
        {
            // problems
            AnActualProblem ap = new AnActualProblem();
            GradingProblem gp = new GradingProblem();

            // Sorting algorithms
            SortAlgorithm ms = new MergeSort();
            QuickSort qs = new QuickSort();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI(gp,qs));
        }
    }
}
