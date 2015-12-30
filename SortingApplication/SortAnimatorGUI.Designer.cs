namespace SortingApplication
{
    partial class SortAnimatorGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manualButton = new System.Windows.Forms.Button();
            this.timedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(49, 160);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(334, 23);
            this.manualButton.TabIndex = 0;
            this.manualButton.Text = "No events";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // timedButton
            // 
            this.timedButton.Location = new System.Drawing.Point(49, 215);
            this.timedButton.Name = "timedButton";
            this.timedButton.Size = new System.Drawing.Size(334, 23);
            this.timedButton.TabIndex = 1;
            this.timedButton.Text = "Animate sorting";
            this.timedButton.UseVisualStyleBackColor = true;
            this.timedButton.Click += new System.EventHandler(this.timedButton_Click);
            // 
            // SortAnimatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 261);
            this.Controls.Add(this.timedButton);
            this.Controls.Add(this.manualButton);
            this.Name = "SortAnimatorGUI";
            this.Text = "SortAnimatorGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button timedButton;
    }
}