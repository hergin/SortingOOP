using System;
using System.Linq;

namespace SortingApplication
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
            this.passedToTheAlgorithm.Text =  string.Join(",",theProblem.getDataForAlgorithm().getData().ToArray());

            this.algorithmName.Text = theAlgorithm.getName();

            int location = 185;
            int step = 30;
            foreach (var item in this.theAlgorithm.getParams())
            {
                var concreteParam = new System.Windows.Forms.Label();
                concreteParam.AutoSize = true;
                concreteParam.Location = new System.Drawing.Point(118, location);
                concreteParam.Name = item.Key+"_Label";
                concreteParam.Size = new System.Drawing.Size(64, 13);
                concreteParam.TabIndex = 6;
                concreteParam.Text = item.Key;
                this.Controls.Add(concreteParam);

                var concreteTextbox = new System.Windows.Forms.TextBox();
                concreteTextbox.Location = new System.Drawing.Point(201, location - 3);
                concreteTextbox.Name = item.Key + "_Val";
                concreteTextbox.Size = new System.Drawing.Size(100, 20);
                concreteTextbox.Tag = item.Key;
                concreteTextbox.TabIndex = 7;
                concreteTextbox.Text = item.Value;
                concreteTextbox.TextChanged += textBox_changed;
                this.Controls.Add(concreteTextbox);

                location += step;
            }

            

        }

        private void textBox_changed(object sender, EventArgs e)
        {
            var tb = ((System.Windows.Forms.TextBox)sender);
            theAlgorithm.updateParam((String)tb.Tag,tb.Text);
            //Console.WriteLine(string.Join(",",theAlgorithm.getParams().ToArray()));
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SortingApplication.AnActualProblem anActualProblem1 = new SortingApplication.AnActualProblem();
            SortingApplication.GradingProblem gradingProblem1 = new SortingApplication.GradingProblem();
            SortingApplication.QuickSort quickSort1 = new SortingApplication.QuickSort();
            SortingApplication.MergeSort mergeSort1 = new SortingApplication.MergeSort();
            this.problemName = new System.Windows.Forms.Label();
            this.problemDescription = new System.Windows.Forms.Label();
            this.passedToAlgorithmLabel = new System.Windows.Forms.Label();
            this.passedToTheAlgorithm = new System.Windows.Forms.Label();
            this.algorithmName = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.solvedLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // problemName
            // 
            this.problemName.AutoSize = true;
            this.problemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemName.Location = new System.Drawing.Point(34, 47);
            this.problemName.Name = "problemName";
            this.problemName.Size = new System.Drawing.Size(108, 16);
            this.problemName.TabIndex = 0;
            this.problemName.Text = "Problem name";
            // 
            // problemDescription
            // 
            this.problemDescription.AutoSize = true;
            this.problemDescription.Location = new System.Drawing.Point(34, 73);
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Size = new System.Drawing.Size(99, 13);
            this.problemDescription.TabIndex = 1;
            this.problemDescription.Text = "Problem description";
            // 
            // passedToAlgorithmLabel
            // 
            this.passedToAlgorithmLabel.AutoSize = true;
            this.passedToAlgorithmLabel.Location = new System.Drawing.Point(34, 110);
            this.passedToAlgorithmLabel.Name = "passedToAlgorithmLabel";
            this.passedToAlgorithmLabel.Size = new System.Drawing.Size(120, 13);
            this.passedToAlgorithmLabel.TabIndex = 2;
            this.passedToAlgorithmLabel.Text = "Passed to the algorithm:";
            // 
            // passedToTheAlgorithm
            // 
            this.passedToTheAlgorithm.AutoSize = true;
            this.passedToTheAlgorithm.Location = new System.Drawing.Point(161, 109);
            this.passedToTheAlgorithm.Name = "passedToTheAlgorithm";
            this.passedToTheAlgorithm.Size = new System.Drawing.Size(28, 13);
            this.passedToTheAlgorithm.TabIndex = 3;
            this.passedToTheAlgorithm.Text = "a list";
            // 
            // algorithmName
            // 
            this.algorithmName.AutoSize = true;
            this.algorithmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmName.Location = new System.Drawing.Point(36, 151);
            this.algorithmName.Name = "algorithmName";
            this.algorithmName.Size = new System.Drawing.Size(118, 16);
            this.algorithmName.TabIndex = 4;
            this.algorithmName.Text = "Algorithm Name";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(39, 330);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(39, 398);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(47, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result:";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(85, 398);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(138, 13);
            this.resultText.TabIndex = 8;
            this.resultText.Text = "click Solve to see sorted list";
            // 
            // solvedLabel
            // 
            this.solvedLabel.AutoSize = true;
            this.solvedLabel.Location = new System.Drawing.Point(120, 335);
            this.solvedLabel.Name = "solvedLabel";
            this.solvedLabel.Size = new System.Drawing.Size(0, 13);
            this.solvedLabel.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem1.Text = "Problem";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem2.Text = "Algorithm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Params";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem3.Tag = anActualProblem1;
            this.toolStripMenuItem3.Text = "An actual problem";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.problemMenuClicked);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem4.Tag = gradingProblem1;
            this.toolStripMenuItem4.Text = "Grading students";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.problemMenuClicked);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem5.Tag = quickSort1;
            this.toolStripMenuItem5.Text = "Quick sort";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.algorithmMenuClicked);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem6.Tag = mergeSort1;
            this.toolStripMenuItem6.Text = "Merge sort";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.algorithmMenuClicked);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solvedLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.algorithmName);
            this.Controls.Add(this.passedToTheAlgorithm);
            this.Controls.Add(this.passedToAlgorithmLabel);
            this.Controls.Add(this.problemDescription);
            this.Controls.Add(this.problemName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemName;
        private System.Windows.Forms.Label problemDescription;
        private System.Windows.Forms.Label passedToAlgorithmLabel;
        private System.Windows.Forms.Label passedToTheAlgorithm;
        private System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label solvedLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label label1;
    }
}

