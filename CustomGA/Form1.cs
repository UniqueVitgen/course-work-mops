using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void bRun_Click(object sender, EventArgs e)
        {

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
            else if (vChromossomes <= 0) MessageBox.Show("Chromossomes must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vIterations <= 0) MessageBox.Show("Iterations must be higher than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (vMutation < 0 || vMutation > 1) MessageBox.Show("Mutation must be between 0 and 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                GA ga = new GA(vPopulation, vChromossomes, vIterations, vMutation, vMin, vMax);
                ga.run();
            }
        }
    }
}
