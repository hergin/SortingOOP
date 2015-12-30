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
    public partial class SortAnimatorGUI : Form, Interfaces.NumberSwapListener, Interfaces.ProblemChangedListener
    {

        Label[] theListLabels;
        LinkedList<Tuple<int,int>> events;

        bool selectMode = true;

        Timer timer = new Timer();

        public SortAnimatorGUI()
        {
            InitializeComponent();

            initializeSortAnimator(new List<Tuple<string, int>>());

        }

        private void initializeSortAnimator(List<Tuple<String, int>> theList)
        {
            events = new LinkedList<Tuple<int, int>>();
            theListLabels = new Label[theList.Count];
            int nextX = 37;
            for (int i = 0; i < theList.Count; i++)
            {
                Label tempLabel = new System.Windows.Forms.Label();
                tempLabel.AutoSize = true;
                tempLabel.Location = new System.Drawing.Point(nextX, 56);
                nextX += 40;
                tempLabel.Name = "label" + i;
                tempLabel.Size = new System.Drawing.Size(20, 20);
                tempLabel.TabIndex = i;
                tempLabel.Text = theList[i].Item2 + "";
                this.Controls.Add(tempLabel);
                theListLabels[i] = tempLabel;
            }

            this.manualButton.Text = "Select next from " + events.Count + " number swap events";

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
        }

        private void selectNext()
        {
            this.selectMode = false;
            Tuple<int, int> nextEvent = events.First();
            theListLabels[nextEvent.Item1].BackColor = Color.Gold;
            theListLabels[nextEvent.Item2].BackColor = Color.Gold;
            this.manualButton.Text = "Swap selected tuple!";
        }

        private void swapNext()
        {
            this.selectMode = true;
            Tuple<int, int> nextEvent = events.First();
            this.manualButton.Text = "Select next from " + events.Count + " events";
            String temp = theListLabels[nextEvent.Item1].Text;
            theListLabels[nextEvent.Item1].Text = theListLabels[nextEvent.Item2].Text;
            theListLabels[nextEvent.Item2].Text = temp;
            events.RemoveFirst();
        }

        private void clearLabelBackgrounds()
        {
            // clear label backgrounds
            foreach (Label l in theListLabels)
            {
                l.BackColor = Color.Empty;
            }
        }

        public void onNumberSwapped(int x, int y)
        {
            events.AddLast(new Tuple<int, int>(x, y));
            this.manualButton.Text = "Select next from " + events.Count + " number swap events";
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            if (events.Count == 0)
            {
                this.manualButton.Text = "No events";
                return;
            }

            clearLabelBackgrounds();

            if (selectMode)
            {
                selectNext();
            }
            else
            {
                swapNext();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {

            if (events.Count == 0)
            {
                timer.Stop();
                this.manualButton.Text = "No events";
                return;
            }

            clearLabelBackgrounds();

            if (selectMode)
            {
                selectNext();
            }
            else
            {
                swapNext();
            }
        }

        private void timedButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
           // timer.Start();
        }

        public void onProblemChanged(ProblemToAlgorithm data)
        {

            foreach (Label l in theListLabels)
            {
                this.Controls.Remove(l);
            }

            initializeSortAnimator(data.getData());
        }
    }
}
