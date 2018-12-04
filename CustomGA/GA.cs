using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public GA(int countPopulation, int countChromossomes, int numberIteration, double mutationRate, double minValue, double maxValue)
        {
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

        public double[] createResults(int[,] multiArr)
        {
            double[] results = new double[this.countPopulation];
            for (int i = 0; i < this.values.GetLength(0); i++)
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
                int firstIndex = RandomWorker.GetRandomNumber(r, 0, countPopulation);
                int lastIndex = RandomWorker.GetRandomNumber(r, firstIndex + 1, countPopulation);
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

        //public int[,] getHalfTheBest(int[,] multiArray)
        //{
        //    int[] results = 
        //}
        public void run()
        {
            int[,] children;
            this.times = createTimes(this.countChromossomes);
            this.values = createValues();
            this.results = createResults();
            FileWorker.WriteToFile(times, "log.txt", WriteModeEnum.NEW);
            FileWorker.WriteToFile(values, results, -1, "log.txt", WriteModeEnum.APPEND);
            //for(int i = 0; i < countPopulation; i++)
            //{
                children = createchildren(this.values);
            double[] childrenResults = createResults(children);
            FileWorker.WriteToFile(values, results, -1, "parent.txt", WriteModeEnum.NEW);
            FileWorker.WriteToFile(children, childrenResults, -1, "children.txt", WriteModeEnum.NEW);
            //}
        }
    }
}
