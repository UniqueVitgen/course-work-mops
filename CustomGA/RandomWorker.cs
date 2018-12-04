using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGA
{
    class  RandomWorker
    {

        public static double GenerateRandomNumber(Random r, double min, double max)
        {
                return r.NextDouble() * (max - min) + min;
        }

        public static int GetRandomNumber(Random r, int min, int max)
        {
            return r.Next(min, max);
        }

        public static int[] GetRandomNumbers(Random random, int count)
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number;

                do number = random.Next(1, count + 1);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            return randomNumbers.ToArray();
        }
    }
}
