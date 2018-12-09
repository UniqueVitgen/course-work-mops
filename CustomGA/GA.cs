using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CustomGA
{
    class GA
    {
        int countPopulation;
        int countChromossomes;
        int countIterations;
        double minValue;
        double maxValue;
        double mutationRate;
        private double mutationRage;
        public int[,] values { get; set; }
        public double[,] times { get; set; }
        public double[] results { get; set; }
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.ProgressBar pbAlgo;
        private System.Windows.Forms.TextBox tbFitness;
        private System.Windows.Forms.TextBox tbCurrentIteration;

        public GA(int countPopulation, int countChromossomes, int numberIteration, double mutationRate, double minValue, double maxValue,
            System.Windows.Forms.DataVisualization.Charting.Chart chart1, System.Windows.Forms.ProgressBar pbAlgo,
            System.Windows.Forms.TextBox tbFitness,
            System.Windows.Forms.TextBox tbCurrentIteration
            )
        {
            this.chart1 = chart1;
            this.pbAlgo = pbAlgo;
            this.tbFitness = tbFitness;
            this.tbCurrentIteration = tbCurrentIteration;

            this.countPopulation = countPopulation;
            this.countChromossomes = countChromossomes;
            this.countIterations = numberIteration;
            this.mutationRage = mutationRate;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        private double[,] createTimes(int countGens)
        {
            double[,] times = new double[countGens, countGens];
            Random r = new Random();
            for (int i = 0; i < countGens; i++)
            {
                for (int j = 0; j < countGens; j++)
                {
                    if (times[i, j] == 0)
                    {
                        double value = RandomWorker.GenerateRandomNumber(r, minValue, maxValue);
                        times[i, j] = value;
                        times[j, i] = value;
                    }
                }
            }
            return times;
        }

        public int[,] createValues()
        {
            Random r = new Random();
            int[,] values = new int[this.countPopulation, this.countChromossomes];
            for(int i = 0; i < this.countPopulation; i++)
            {
                int[] uniqueRandomArray = RandomWorker.GetRandomNumbers(r, countChromossomes);
                for (int j = 0; j < countChromossomes; j++)
                {
                    values[i, j] = uniqueRandomArray[j];
                }
            }
            return values;
        }

        public double[] createResults()
        {
            double[] results = new double[this.countPopulation];
            for(int i = 0; i < this.values.GetLength(0); i++)
            {
               int[] row = ArrayWorker.GetRow(this.values, i);
                double result = calculateTime(row);
                results[i] = result;
            }
            return results;
        }

        public List<Tuple<int, double>> createResultsWithTupples(int[,] multiArr)
        {
            double[] results = createResults(multiArr);
            List<Tuple<int, double>> list = new List<Tuple<int, double>>();
            for (int i = 0; i < results.Length; i++)
            {
                list.Add(new Tuple<int, double>(i, results[i]));
            }
            return list;
        }

        public double[] createResults(int[,] multiArr)
        {
            double[] results = new double[multiArr.GetLength(0)];
            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                int[] row = ArrayWorker.GetRow(multiArr, i);
                double result = calculateTime(row);
                results[i] = result;
            }
            return results;
        }

        public double calculateTime(int[] array)
        {
            double sum = 0;
            for(int i = 1; i < array.Length - 1; i++)
            {
                int firstIndex = array[i - 1] - 1;
                int lastIndex = array[i] - 1;
                double value = this.times[firstIndex, lastIndex];
                sum += value;
            }
            return sum;
        }

        public int[,] createchildren(int[,] parents)
        {
            Random r = new Random();
            int[,] children = new int[countPopulation, countChromossomes];
            for (int i = 0; i < (countPopulation / 2); i++)
            {
                int firstIndex = RandomWorker.GetRandomNumber(r, 0, countPopulation -1);
                int lastIndex = RandomWorker.GetRandomNumber(r, firstIndex + 1, countPopulation -1);
                int[] parent1 = ArrayWorker.GetRow(parents, firstIndex);
                int[] parent2 = ArrayWorker.GetRow(parents, lastIndex);
                int[,] twoChildren = createTwoChildren(parent1, parent2);
                int[] child1 = ArrayWorker.GetRow(twoChildren, 0);
                int[] child2 = ArrayWorker.GetRow(twoChildren, 1);
                ArrayWorker.setRow(children, child1, i * 2 + 0);
                ArrayWorker.setRow(children, child2, i * 2 + 1);
            }
            return children;
        }

        public int[,] createTwoChildren(int[] parent1, int[] parent2)
        {
            Random r = new Random();
            int firstIndex = RandomWorker.GetRandomNumber(r, 0, countChromossomes);
            int lastIndex = RandomWorker.GetRandomNumber(r, firstIndex + 1, countChromossomes);
            int[,] children = new int[2, this.countChromossomes];
            for (int i = 0; i < this.countChromossomes; i++)
            {
                if (i >= firstIndex && i < lastIndex)
                {
                    children[0, i] = parent2[i];
                    children[1, i] = parent1[i];
                }
                else
                {
                    children[0, i] = parent1[i];
                    children[1, i] = parent2[i];
                }
            }
            int[] child1 = ArrayWorker.GetRow(children, 0);
            int[] child2 = ArrayWorker.GetRow(children, 1);
            FileWorker.WriteToFile(parent1, "pmx.txt", WriteModeEnum.NEW);
            FileWorker.WriteToFile(parent2, "pmx.txt", WriteModeEnum.APPEND);
            FileWorker.AppendTextToFile("pmx.txt", Environment.NewLine);
            FileWorker.WriteToFile(child1, "pmx.txt", WriteModeEnum.APPEND);
            FileWorker.WriteToFile(child2, "pmx.txt", WriteModeEnum.APPEND);
            FileWorker.AppendTextToFile("pmx.txt", Environment.NewLine);
            FileWorker.AppendTextToFile("pmx.txt", "1 index" + firstIndex + Environment.NewLine
                + "2 index" + lastIndex + Environment.NewLine);
            for (;
                !ArrayWorker.IsHaveOnlyUniqueValues(child1) || !ArrayWorker.IsHaveOnlyUniqueValues(child2); )
            {
                int DuplicateIndexOfFirstArray = ArrayWorker.indexOfDuplicateValueWithout(child1, firstIndex, lastIndex);
                int DuplicateIndexOfSecondArray = ArrayWorker.indexOfDuplicateValueWithout(child2, firstIndex, lastIndex);
                int temp1 = child1[DuplicateIndexOfFirstArray];
                int temp2 = child2[DuplicateIndexOfSecondArray];
                child1[DuplicateIndexOfFirstArray] = temp2;
                child2[DuplicateIndexOfSecondArray] = temp1;
            }
            FileWorker.AppendTextToFile("pmx.txt", Environment.NewLine);
            FileWorker.WriteToFile(child1, "pmx.txt", WriteModeEnum.APPEND);
            FileWorker.WriteToFile(child2, "pmx.txt", WriteModeEnum.APPEND);
            for (int i = 0; i < this.countChromossomes; i++)
            {
                    children[0, i] = child1[i];
                    children[1, i] = child2[i];
            }
            return children;
        }

        public int[,] doMutation(int[,] multiArray)
        {
            FileWorker.WriteToFile(multiArray, "mutation.txt", WriteModeEnum.NEW);
            Random r = new Random();
            int RowIndex = RandomWorker.GetRandomNumber(r, 0, multiArray.GetLength(0));
            int[] row = ArrayWorker.GetRow(multiArray, RowIndex);
            int firstIndex = RandomWorker.GetRandomNumber(r, 0, row.Length - 1);
            int lastIndex = RandomWorker.GetRandomNumber(r, firstIndex + 1, row.Length - 1);
            int temp1 = row[firstIndex];
            int temp2 = row[lastIndex];
            row[firstIndex] = temp2;
            row[lastIndex] = temp1;
            ArrayWorker.setRow(multiArray, row, RowIndex);
            FileWorker.AppendTextToFile("mutation.txt", "first - " + firstIndex + ";" + Environment.NewLine);
            FileWorker.AppendTextToFile("mutation.txt", "last - " + lastIndex + ";" + Environment.NewLine);
            FileWorker.AppendTextToFile("mutation.txt", Environment.NewLine);
            FileWorker.WriteToFile(multiArray, "mutation.txt", WriteModeEnum.APPEND);
            return multiArray;
        }

        public int[,] getHalfTheBest(int[,] multiArray)
        {
            List<Tuple<int, double>> resultsWithIndexes = createResultsWithTupples(multiArray);
            resultsWithIndexes.Sort((a, b) =>
            {
                if(a.Item2 < b.Item2)
                {
                    return -1;
                }
                else if(a.Item2 == b.Item2)
                {
                    return 0;
                } else
                {
                    return 1;
                }
            });

            int[] indexes = new int[multiArray.GetLength(0) / 2];
            int[,] halfTheBestMultiArray = new int[multiArray.GetLength(0) / 2, multiArray.GetLength(1)];

            for(int i = 0; i < indexes.Length; i++)
            {
                int indexRow = resultsWithIndexes[i].Item1;
                int[] bestArray = ArrayWorker.GetRow(multiArray, indexRow);
                ArrayWorker.setRow(halfTheBestMultiArray, bestArray, i);
            }
            return halfTheBestMultiArray;

        }

        public double getTheBest(int[,] multiArray)
        {
            List<Tuple<int, double>> resultsWithIndexes = createResultsWithTupples(multiArray);
            resultsWithIndexes.Sort((a, b) =>
            {
                if (a.Item2 < b.Item2)
                {
                    return -1;
                }
                else if (a.Item2 == b.Item2)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            });
            
            
            return resultsWithIndexes[0].Item2;
        }


        public void UpdateGraph(int i, double fitness)
        {
            //refresh grid config
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.Maximum = fitness * 2; //approximate y scale as the values increase/decrease for better visualization

            //add point to graph: i = iteration, fitness = y value
            chart1.Series[0].Points.AddXY(i, fitness);
        }

        public void UpdateResultsLabel(int iteration, double fitness)
        {
            tbFitness.Text = "" + fitness;
            tbCurrentIteration.Text = "" + iteration;
            int percent = (iteration * 100 / (countIterations - 1));
            pbAlgo.Value = percent;
        }

        public void run()
        {
            int[,] children;
            this.times = createTimes(this.countChromossomes);
            this.values = createValues();
            string filepath = Path.Combine(".", "log_" + DateTime.Now.ToString("yyyy_dd_MMMM_HH_mm_ss") + ".txt");
            FileWorker.WriteToFile(times, filepath, WriteModeEnum.NEW);
            this.results = createResults(this.values);
            Random r = new Random();
            double randomValue;
            double bestFitness = getTheBest(this.values);
            for (int i = 0; i < countIterations; i++)
            {
                randomValue = RandomWorker.GenerateRandomNumber(r, 0, 1);
                this.results = createResults(this.values);
                FileWorker.WriteToFile(values, results, i, filepath, WriteModeEnum.APPEND);
                if(bestFitness != 0)
                {
                    FileWorker.AppendTextToFile(filepath, "best fintess - " + bestFitness + Environment.NewLine);
                }
                // crossing
                children = createchildren(this.values);


                // mutation
                if (randomValue < mutationRage)
                {
                    this.values = doMutation(this.values);
                }
                // next poppulation
                int[,] halfTheBestChildren = getHalfTheBest(children);
                int[,] halfTheBestParent = getHalfTheBest(this.values);
                int[,] nextGen = ArrayWorker.Concat(halfTheBestParent, halfTheBestChildren);
                this.values = nextGen;
                bestFitness = getTheBest(this.values);
                UpdateGraph(i, bestFitness);
                UpdateResultsLabel(i, bestFitness);
                //double[] childrenResults = createResults(children);
                //double[] halfChildrenResults = createResults(halfTheBestChildren);
                //double[] halfParentResults = createResults(halfTheBestParent);
                //double[] NextGenResults = createResults(nextGen);
                //FileWorker.WriteToFile(children, childrenResults, -1, "children.txt", WriteModeEnum.NEW);
                //FileWorker.WriteToFile(halfTheBestChildren, halfChildrenResults, 0, "children.txt", WriteModeEnum.APPEND);
                //FileWorker.WriteToFile(values, results, -1, "parent.txt", WriteModeEnum.NEW);
                //FileWorker.WriteToFile(halfTheBestParent, halfParentResults, 0, "parent.txt", WriteModeEnum.APPEND);
                //FileWorker.WriteToFile(nextGen, NextGenResults, 0, "next-gen.txt", WriteModeEnum.APPEND);
                //FileWorker.WriteToFile(children, childrenResults, -1, "children.txt", WriteModeEnum.NEW);
            }
        }
    }
}
