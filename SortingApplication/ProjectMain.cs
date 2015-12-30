using SortingApplication.Interfaces;
using SortingApplication.Model;
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

            // Sorting algorithms
            SortAlgorithm ms = new MergeSort();
            SortAlgorithm qs = new QuickSort();
            

            //SortingVisualiser visualiser = new SortingVisualiser(ap.getDataForAlgorithm().getData());
            //qs.setNumberSwapListener(visualiser);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SortAnimatorGUI sortAnimator = new SortAnimatorGUI();
            qs.setNumberSwapListener(sortAnimator);
            sortAnimator.Show();

            GUI sortGui = new GUI(qs);
            sortGui.setProblemChangedListener(sortAnimator);

            Application.Run(sortGui);
        }
    }
}
