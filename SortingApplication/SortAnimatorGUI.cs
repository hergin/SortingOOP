using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApplication
{
    public partial class SortAnimatorGUI : Form, Interfaces.NumberSwapListener
    {

        Label[] theListLabels;
        LinkedList<Tuple<int,int>> events;

        bool selectMode = true;

        Timer timer = new Timer();

        public SortAnimatorGUI(int[] theList)
        {
            InitializeComponent();

            events = new LinkedList<Tuple<int, int>>();
            theListLabels = new Label[theList.Length];
            int nextX = 37;
            for (int i = 0; i < theList.Length; i++)
            {
                Label tempLabel = new System.Windows.Forms.Label();
                tempLabel.AutoSize = true;
                tempLabel.Location = new System.Drawing.Point(nextX, 56);
                nextX += 40;
                tempLabel.Name = "label" + i;
                tempLabel.Size = new System.Drawing.Size(20, 20);
                tempLabel.TabIndex = i;
                tempLabel.Text = theList[i] + "";
                this.Controls.Add(tempLabel);
                theListLabels[i] = tempLabel;
            }

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;

        }

        void timer_Tick(object sender, EventArgs e)
        {

            if (events.Count == 0)
            {
                timer.Stop();
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

        private void selectNext()
        {
            Tuple<int, int> nextEvent = events.First();
            theListLabels[nextEvent.Item1].BackColor = Color.Gold;
            theListLabels[nextEvent.Item2].BackColor = Color.Gold;
            this.button1.Text = "Swap selected tuple!";
            this.selectMode = false;
        }

        private void swapNext()
        {
            Tuple<int, int> nextEvent = events.First();
            this.button1.Text = "Select next from " + events.Count + " events";
            String temp = theListLabels[nextEvent.Item1].Text;
            theListLabels[nextEvent.Item1].Text = theListLabels[nextEvent.Item2].Text;
            theListLabels[nextEvent.Item2].Text = temp;
            events.RemoveFirst();
            this.selectMode = true;
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
            this.button1.Text = "Select next from " + events.Count + " number swap events";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (events.Count == 0)
            {
                this.button1.Text = "No events";
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }
    }
}
