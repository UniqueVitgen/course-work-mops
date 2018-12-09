namespace CustomGA
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.tbMutation = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbChromossomes = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCurrentIteration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFitness = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbAlgo = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIterations);
            this.groupBox1.Controls.Add(this.tbMutation);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tbChromossomes);
            this.groupBox1.Controls.Add(this.tbPopulation);
            this.groupBox1.Controls.Add(this.bStop);
            this.groupBox1.Controls.Add(this.bRun);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(9, 237);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(180, 20);
            this.tbIterations.TabIndex = 7;
            this.tbIterations.Text = "8";
            // 
            // tbMutation
            // 
            this.tbMutation.Location = new System.Drawing.Point(9, 195);
            this.tbMutation.Name = "tbMutation";
            this.tbMutation.Size = new System.Drawing.Size(180, 20);
            this.tbMutation.TabIndex = 4;
            this.tbMutation.Text = "0.1";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(9, 155);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(180, 20);
            this.tbMax.TabIndex = 3;
            this.tbMax.Text = "10";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(9, 115);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(180, 20);
            this.tbMin.TabIndex = 2;
            this.tbMin.Text = "1";
            // 
            // tbChromossomes
            // 
            this.tbChromossomes.Location = new System.Drawing.Point(9, 75);
            this.tbChromossomes.Name = "tbChromossomes";
            this.tbChromossomes.Size = new System.Drawing.Size(180, 20);
            this.tbChromossomes.TabIndex = 1;
            this.tbChromossomes.Text = "6";
            // 
            // tbPopulation
            // 
            this.tbPopulation.Location = new System.Drawing.Point(9, 36);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(180, 20);
            this.tbPopulation.TabIndex = 0;
            this.tbPopulation.Text = "4";
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(33, 343);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(78, 48);
            this.bStop.TabIndex = 9;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Visible = false;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(9, 275);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(180, 48);
            this.bRun.TabIndex = 8;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Iterations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mutation Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max. Time Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min. Time Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Population:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gens:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCurrentIteration);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbFitness);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(224, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // tbCurrentIteration
            // 
            this.tbCurrentIteration.Location = new System.Drawing.Point(121, 42);
            this.tbCurrentIteration.Name = "tbCurrentIteration";
            this.tbCurrentIteration.ReadOnly = true;
            this.tbCurrentIteration.Size = new System.Drawing.Size(124, 20);
            this.tbCurrentIteration.TabIndex = 3;
            this.tbCurrentIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Current Iteration:";
            // 
            // tbFitness
            // 
            this.tbFitness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFitness.Location = new System.Drawing.Point(121, 19);
            this.tbFitness.Name = "tbFitness";
            this.tbFitness.ReadOnly = true;
            this.tbFitness.Size = new System.Drawing.Size(124, 20);
            this.tbFitness.TabIndex = 1;
            this.tbFitness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Best Fitness:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(233, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chart1
            // 
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(9, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(536, 310);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // pbAlgo
            // 
            this.pbAlgo.Location = new System.Drawing.Point(12, 419);
            this.pbAlgo.Name = "pbAlgo";
            this.pbAlgo.Size = new System.Drawing.Size(787, 23);
            this.pbAlgo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 470);
            this.Controls.Add(this.pbAlgo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.TextBox tbMutation;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbChromossomes;
        private System.Windows.Forms.TextBox tbPopulation;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCurrentIteration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFitness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar pbAlgo;
    }
}

