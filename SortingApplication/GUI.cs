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

namespace SortingApplication
{
    public partial class GUI : Form
    {
        private SortAlgorithm theAlgorithm;
        private Problem theProblem;

        public GUI(Problem p,SortAlgorithm s)
        {
            theProblem = p;
            theAlgorithm = s;
            InitializeComponent();
            initializeGUI();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            this.resultText.Text = string.Join(",", theAlgorithm.sort(theProblem.getDataForAlgorithm()));
            this.solvedLabel.Text = "I solved " + theProblem.getName() + " using " + theAlgorithm.getName() + ".";
        }

        private void problemMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            theProblem = (Problem)((ToolStripMenuItem)sender).Tag;
            initializeGUI();
        }

        private void algorithmMenuClicked(object sender, EventArgs e)
        {
            clearOldStuff();
            theAlgorithm = (SortAlgorithm)((ToolStripMenuItem)sender).Tag;
            initializeGUI();
        }
        
    }
}
