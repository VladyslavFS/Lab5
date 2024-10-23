using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                int n = int.Parse(txtN.Text);

                if (a >= b || n <= 0)
                {
                    throw new ArgumentException("Invalid range or sample size.");
                }

                double[] sample = GenerateUniformSample(a, b, n);

                var histogramSeries = new ColumnSeries<double>
                {
                    Values = sample,
                    XToolTipLabelFormatter = point => $"{point.PrimaryValue:N2}"
                };

                chart.Series = new ISeries[] { histogramSeries };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] GenerateUniformSample(double a, double b, int n)
        {
            Random rand = new Random();
            double[] sample = new double[n];

            for (int i = 0; i < n; i++)
            {
                sample[i] = a + rand.NextDouble() * (b - a);
            }

            return sample;
        }
    }
}
