namespace GraphGUITest4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            barPlot = new ScottPlot.FormsPlot();
            Plot2 = new ScottPlot.FormsPlot();
            Plot3 = new ScottPlot.FormsPlot();
            Plot4 = new ScottPlot.FormsPlot();
            scat = new ScottPlot.FormsPlot();
            btn_Reset = new Button();
            lblScat = new Label();
            SuspendLayout();
            // 
            // barPlot
            // 
            barPlot.Location = new Point(1670, 3);
            barPlot.Margin = new Padding(8, 6, 8, 6);
            barPlot.Name = "barPlot";
            barPlot.Size = new Size(708, 486);
            barPlot.TabIndex = 0;
            barPlot.Load += formsPlot1_Load;
            // 
            // Plot2
            // 
            Plot2.Location = new Point(886, 3);
            Plot2.Margin = new Padding(8, 6, 8, 6);
            Plot2.Name = "Plot2";
            Plot2.Size = new Size(728, 486);
            Plot2.TabIndex = 1;
            Plot2.Load += formsPlot2_Load;
            // 
            // Plot3
            // 
            Plot3.Location = new Point(6, 3);
            Plot3.Margin = new Padding(8, 6, 8, 6);
            Plot3.Name = "Plot3";
            Plot3.Size = new Size(890, 754);
            Plot3.TabIndex = 2;
            // 
            // Plot4
            // 
            Plot4.Location = new Point(6, 755);
            Plot4.Margin = new Padding(8, 6, 8, 6);
            Plot4.Name = "Plot4";
            Plot4.Size = new Size(890, 747);
            Plot4.TabIndex = 3;
            // 
            // scat
            // 
            scat.Location = new Point(912, 583);
            scat.Margin = new Padding(8, 6, 8, 6);
            scat.Name = "scat";
            scat.Size = new Size(1466, 919);
            scat.TabIndex = 4;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(1057, 513);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(150, 46);
            btn_Reset.TabIndex = 5;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click_1;
            // 
            // lblScat
            // 
            lblScat.AutoSize = true;
            lblScat.Location = new Point(1300, 519);
            lblScat.Name = "lblScat";
            lblScat.Size = new Size(255, 32);
            lblScat.TabIndex = 6;
            lblScat.Text = "Screen Time Spending";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2486, 1498);
            Controls.Add(lblScat);
            Controls.Add(btn_Reset);
            Controls.Add(scat);
            Controls.Add(Plot4);
            Controls.Add(Plot3);
            Controls.Add(Plot2);
            Controls.Add(barPlot);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot barPlot;
        private ScottPlot.FormsPlot Plot2;
        private ScottPlot.FormsPlot Plot3;
        private ScottPlot.FormsPlot Plot4;
        private ScottPlot.FormsPlot scat;
        private Button btn_Reset;
        private Label lblScat;
    }
}