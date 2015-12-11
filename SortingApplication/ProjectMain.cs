using SortingApplication.Interfaces;
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

            

            //SortingVisualiser visualiser = new SortingVisualiser(ap.getDataForAlgorithm().getData());
            //ms.setNumberSwapListener(visualiser);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SortAnimatorGUI sortAnimator = new SortAnimatorGUI(ap.getDataForAlgorithm().getData().ToArray());
            ms.setNumberSwapListener(sortAnimator);
            sortAnimator.Show();

            Application.Run(new GUI(ap,ms));
        }
    }
}
