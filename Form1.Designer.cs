namespace Lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblN;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.chart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();

            // btnGenerate
            this.btnGenerate.Location = new System.Drawing.Point(150, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // txtA
            this.txtA.Location = new System.Drawing.Point(50, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(50, 23);
            this.txtA.TabIndex = 1;

            // txtB
            this.txtB.Location = new System.Drawing.Point(150, 30);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(50, 23);
            this.txtB.TabIndex = 2;

            // txtN
            this.txtN.Location = new System.Drawing.Point(250, 30);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(50, 23);
            this.txtN.TabIndex = 3;

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 15);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "A";

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(120, 33);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 15);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B";

            // lblN
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(220, 33);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(16, 15);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N";

            // chart
            this.chart.Location = new System.Drawing.Point(20, 140);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(360, 200);
            this.chart.TabIndex = 7;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Uniform Distribution Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
