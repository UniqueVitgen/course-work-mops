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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.tbMutation = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbChromossomes = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.cbFitness = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.cbFitness);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbSelection);
            this.groupBox1.Controls.Add(this.label7);
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
            this.tbIterations.Location = new System.Drawing.Point(9, 315);
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
            this.bStop.Location = new System.Drawing.Point(111, 353);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(78, 48);
            this.bStop.TabIndex = 9;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(9, 353);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(78, 48);
            this.bRun.TabIndex = 8;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // cbFitness
            // 
            this.cbFitness.FormattingEnabled = true;
            this.cbFitness.Location = new System.Drawing.Point(9, 275);
            this.cbFitness.Name = "cbFitness";
            this.cbFitness.Size = new System.Drawing.Size(180, 21);
            this.cbFitness.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fitness Function:";
            // 
            // cbSelection
            // 
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Location = new System.Drawing.Point(9, 235);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(180, 21);
            this.cbSelection.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Selection Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 299);
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
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max. Chromossome Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min. Chromossome Value:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbFitness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

