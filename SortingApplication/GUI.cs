using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingApplication.Interfaces;
using SortingApplication.Model;

namespace SortingApplication
{
    public partial class GUI : Form,NumberSwapListener
    {
        private SortAlgorithm theAlgorithm;
        private Problem theProblem;
        ProblemChangedListener problemChangedListener;

        public GUI(SortAlgorithm s)
        {
            theProblem = ProblemFactory.createActualProblem();
            theAlgorithm = s;
            InitializeComponent();
            initializeGUI();
        }

        public void setProblemChangedListener(ProblemChangedListener pcl)
        {
            this.problemChangedListener = pcl;
            if (problemChangedListener != null)
            {
                problemChangedListener.onProblemChanged(theProblem.getDataForAlgorithm());
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            theAlgorithm.sort(theProblem.getDataForAlgorithm());
            this.resultText.Text = theProblem.getDataForAlgorithm().ToString();
            this.solvedLabel.Text = "I solved " + theProblem.getName() + " using " + theAlgorithm.getName() + ".";
        }

        private void actualProblemMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            theProblem = ProblemFactory.createActualProblem();
            if(problemChangedListener!=null)
            {
                problemChangedListener.onProblemChanged(theProblem.getDataForAlgorithm());
            }
            initializeGUI();
        }

        private void gradingProblemMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            theProblem = ProblemFactory.createGradingProblem();
            if (problemChangedListener != null)
            {
                problemChangedListener.onProblemChanged(theProblem.getDataForAlgorithm());
            }
            initializeGUI();
        }


        private void quickSortMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            NumberSwapListener old = theAlgorithm.getNumberSwapListener();
            theAlgorithm = new QuickSort();
            theAlgorithm.setNumberSwapListener(old);
            initializeGUI();
        }

        private void mergeSortMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            NumberSwapListener old = theAlgorithm.getNumberSwapListener();
            theAlgorithm = new MergeSort();
            theAlgorithm.setNumberSwapListener(old);
            initializeGUI();
        }

        public void onNumberSwapped(int x, int y)
        {
            Console.WriteLine("These indices are swapped: ["+x+"] <-> ["+y+"]");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            clearOldStuff();
            theProblem = ProblemFactory.createTestProblem();
            if (problemChangedListener != null)
            {
                problemChangedListener.onProblemChanged(theProblem.getDataForAlgorithm());
            }
            initializeGUI();
        }
    }
}
