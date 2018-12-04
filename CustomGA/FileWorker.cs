using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGA
{
    class FileWorker
    {
        public static void WriteToFile(double[][] array, int iteration, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile(double[,] array, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile(double[,] array, int iteration, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile<T>(T[,] array, double[] results, int iteration, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, results, iteration);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, results, iteration);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile<T>(T[,] array, int iteration, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array, iteration);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile(double[] array, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
        }

        public static void WriteToFile<T>(T[] array, string path, WriteModeEnum writeMode)
        {
            if (writeMode == WriteModeEnum.NEW)
            {
                using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream sw = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    WriteArrayToFileStream(sw, array);
                    sw.Close();
                }
            }
        }

        public static void AppendTextToFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        private static void WriteStringToFileStream(FileStream fs, string target)
        {
            byte[] buff = Encoding.Default.GetBytes(target);
            fs.Write(buff, 0, buff.Length);
        }

        private static void WriteArrayToFileStream(FileStream sw, double[][] array, int iteration)
        {
            string targetString = "iteration: " + iteration + Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
            for (int i = 0; i < array.Length; i++)
            {
                var row = array[i];
                for (int j = 0; j < row.Length; j++)
                {
                    targetString = String.Format("{0:0} ", array[i][j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream(FileStream sw, GA ga, int iteration)
        {
            string targetString = "iteration: " + iteration + Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
            double[,] array = ga.times;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    targetString = String.Format("{0} ", array[i, j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = " - " + ga.results[i] +Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream(FileStream sw, double[][] array)
        {
            string targetString;
            for (int i = 0; i < array.Length; i++)
            {
                var row = array[i];
                for (int j = 0; j < row.Length; j++)
                {
                    targetString = String.Format("{0:0} ", array[i][j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream(FileStream sw, double[,] array, int iteration)
        {
            string targetString = "iteration: " + iteration + Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    targetString = String.Format("{0} ", array[i, j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream<T>(FileStream sw, T[,] array, double[] results, int iteration)
        {
            string targetString = "iteration: " + iteration + Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    targetString = String.Format("{0} ", array[i, j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = " - " + results[i] + Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream<T>(FileStream sw, T[,] array, int iteration)
        {
            string targetString = "iteration: " + iteration + Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    targetString = String.Format("{0} ", array[i, j]);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream(FileStream sw, double[,] array)
        {
            string targetString;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double value = array[i, j];
                    targetString = String.Format("{0:0.000} ", value);
                    WriteStringToFileStream(sw, targetString);
                }
                targetString = Environment.NewLine;
                WriteStringToFileStream(sw, targetString);
            }
        }

        private static void WriteArrayToFileStream(FileStream sw, double[] array)
        {
            string targetString;
            for (int j = 0; j < array.Length; j++)
            {
                targetString = String.Format("{0:0.00000} ", array[j]);
                WriteStringToFileStream(sw, targetString);
            }
            targetString = Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
        }

        private static void WriteArrayToFileStream<T>(FileStream sw, T[] array)
        {
            string targetString;
            for (int j = 0; j < array.Length; j++)
            {
                targetString = String.Format("{0:0.000} ", array[j]);
                WriteStringToFileStream(sw, targetString);
            }
            targetString = Environment.NewLine;
            WriteStringToFileStream(sw, targetString);
        }
    }
}
