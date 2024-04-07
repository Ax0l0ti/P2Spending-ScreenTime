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
            formsPlot1 = new ScottPlot.FormsPlot();
            Plot2 = new ScottPlot.FormsPlot();
            Plot3 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(849, 341);
            formsPlot1.Margin = new Padding(5, 4, 5, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(436, 304);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // Plot2
            // 
            Plot2.Location = new Point(849, 13);
            Plot2.Margin = new Padding(5, 4, 5, 4);
            Plot2.Name = "Plot2";
            Plot2.Size = new Size(448, 304);
            Plot2.TabIndex = 1;
            Plot2.Load += formsPlot2_Load;
            // 
            // Plot3
            // 
            Plot3.Location = new Point(47, 115);
            Plot3.Margin = new Padding(5, 4, 5, 4);
            Plot3.Name = "Plot3";
            Plot3.Size = new Size(730, 491);
            Plot3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 712);
            Controls.Add(Plot3);
            Controls.Add(Plot2);
            Controls.Add(formsPlot1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot Plot2;
        private ScottPlot.FormsPlot Plot3;
    }
}