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

        private void clearOldStuff()
        {
            foreach (var item in this.theAlgorithm.getParams())
            {
                this.Controls.RemoveByKey(item.Key + "_Label");
                this.Controls.RemoveByKey(item.Key + "_Val");
            }
        }

        private void initializeGUI()
        {
            this.problemName.Text = theProblem.getName();
            this.problemDescription.Text = theProblem.getDesc();
            this.passedToTheAlgorithm.Text = theProblem.getDataForAlgorithm().ToString();

            this.algorithmName.Text = theAlgorithm.getName();

            int location = 185;
            int step = 30;
            foreach (var item in this.theAlgorithm.getParams())
            {
                var concreteParam = new System.Windows.Forms.Label();
                concreteParam.AutoSize = true;
                concreteParam.Location = new System.Drawing.Point(118, location);
                concreteParam.Name = item.Key + "_Label";
                concreteParam.Size = new System.Drawing.Size(64, 13);
                concreteParam.TabIndex = 6;
                concreteParam.Text = item.Key;
                this.Controls.Add(concreteParam);

                // IF there are no possible values, it is just a textbox
                if (item.Value.getPossibleValues() == null)
                {
                    var concreteTextbox = new System.Windows.Forms.TextBox();
                    concreteTextbox.Location = new System.Drawing.Point(201, location - 3);
                    concreteTextbox.Name = item.Key + "_Val";
                    concreteTextbox.Size = new System.Drawing.Size(100, 20);
                    concreteTextbox.Tag = item.Value;
                    concreteTextbox.TabIndex = 7;
                    concreteTextbox.Text = (String)item.Value.getID();
                    concreteTextbox.TextChanged += textBox_changed;
                    this.Controls.Add(concreteTextbox);
                }
                // IF possible values contain 'true', it is a checkbox
                else if (item.Value.getPossibleValues().Contains(true))
                {
                    var concreteCheckbox = new System.Windows.Forms.CheckBox();
                    concreteCheckbox.Name = item.Key + "_Val";
                    concreteCheckbox.Location = new System.Drawing.Point(201, location - 3);
                    concreteCheckbox.Size = new System.Drawing.Size(100, 20);
                    concreteCheckbox.Checked = (bool)item.Value.getValue();
                    concreteCheckbox.Tag = item.Value;
                    concreteCheckbox.CheckedChanged += checkbox_changed;
                    this.Controls.Add(concreteCheckbox);
                }
                // ELSE it is a combobox
                else
                {
                    var concreteCombobox = new System.Windows.Forms.ComboBox();
                    concreteCombobox.FormattingEnabled = true;
                    concreteCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    concreteCombobox.Items.AddRange(item.Value.getPossibleValues().ToArray());
                    concreteCombobox.SelectedItem = item.Value.getValue();
                    concreteCombobox.Location = new System.Drawing.Point(201, location - 3);
                    concreteCombobox.Name = item.Key + "_Val";
                    concreteCombobox.Tag = item.Value;
                    concreteCombobox.Size = new System.Drawing.Size(100, 20);
                    concreteCombobox.SelectedValueChanged += ConcreteCombobox_SelectedValueChanged;
                    concreteCombobox.TabIndex = 12;
                    this.Controls.Add(concreteCombobox);
                }
                location += step;
            }



        }

        private void ConcreteCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            var tb = ((System.Windows.Forms.ComboBox)sender);
            theAlgorithm.updateParam(((Model.Parameter)tb.Tag).getID(), tb.SelectedItem);
        }

        private void checkbox_changed(object sender, EventArgs e)
        {
            var tb = ((System.Windows.Forms.CheckBox)sender);
            theAlgorithm.updateParam(((Model.Parameter)tb.Tag).getID(), tb.Checked);
        }

        private void textBox_changed(object sender, EventArgs e)
        {
            var tb = ((System.Windows.Forms.TextBox)sender);
            theAlgorithm.updateParam(((Model.Parameter)tb.Tag).getID(), tb.Text);
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
