using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CustomGA
{
    public partial class Form1 : Form
    {
        int vPopulation;
        int vChromossomes;
        double vMin;
        double vMax;
        double vMutation;
        int vIterations;
        private Random rnd = new Random();
        private double mutationRage;
        private int countIterations;

        public double[,] times;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGraph();
        }

        private void LoadGraph()
        {
            //create and customize the chart area
            ChartArea ca = new ChartArea();
            //ca.AxisX.Interval = 1000;
            ca.AxisX.Minimum = 0;
            ca.AxisX.IsStartedFromZero = true;
            ca.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            ca.AxisX.IntervalType = DateTimeIntervalType.Number;
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisX.MinorGrid.Enabled = false;

            ca.AxisY.LabelStyle.Format = "{0:0.##E+00}";
            ca.AxisY.Minimum = 0;
            ca.AxisY.MajorGrid.Enabled = false;
            ca.AxisY.MinorGrid.Enabled = false;


            //ca.InnerPlotPosition.X = 0;
            //ca.InnerPlotPosition.Y = 0;

            // Height and width are in percentage (%)
            //ca.InnerPlotPosition.Height = 80;
            //ca.InnerPlotPosition.Width = 80;

            //create series as a line chart type
            Series s = new Series()
            {
                ChartType = SeriesChartType.Line,
                LegendText = "Fitness",
                Color = Color.Red
            };

            //add series and chart area to the chart
            chart1.ChartAreas.Add(ca);
            chart1.Series.Add(s);

        }

        private void bRun_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            vPopulation = Int32.TryParse(tbPopulation.Text, out vPopulation) ? vPopulation : -1;
            vChromossomes = Int32.TryParse(tbChromossomes.Text, out vChromossomes) ? vChromossomes : -1;
            vIterations = Int32.TryParse(tbIterations.Text, out vIterations) ? vIterations : -1;
            vMin = Double.TryParse(tbMin.Text, out vMin) ? vMin : -1;
            vMax = Double.TryParse(tbMax.Text, out vMax) ? vMax : -1;
            vMutation = Double.TryParse(tbMutation.Text, out vMutation) ? vMutation : -1;
            //vST = (SelectionType)Enum.Parse(typeof(SelectionType), cbSelection.SelectedItem.ToString());
            //vFF = (FitnessFunction)Enum.Parse(typeof(FitnessFunction), cbFitness.SelectedItem.ToString());

            //checking for errors
            if (vPopulation <= 0 || vPopulation % 2 != 0) MessageBox.Show("Population must be higher than 0 and an even number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vChromossomes <= 0) MessageBox.Show("Gens must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vIterations <= 0) MessageBox.Show("Iterations must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vMin <= 0) MessageBox.Show("Min Time value must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vMax <= 0) MessageBox.Show("Max Time value must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vMin >= vMax) MessageBox.Show("Max Time value must be higher than Min Time value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vMutation < 0 || vMutation > 1) MessageBox.Show("Mutation must be between 0 and 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                GA ga = new GA(vPopulation, vChromossomes, vIterations, vMutation, vMin, vMax, chart1, pbAlgo, tbFitness, tbCurrentIteration);
                ga.run();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
