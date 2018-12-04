using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomGA
{
    class ArrayWorker
    {


        public static T[] GetRow<T>(T[,] array, int row)
        {
            if (!typeof(T).IsPrimitive)
                throw new InvalidOperationException("Not supported for managed types.");

            if (array == null)
                throw new ArgumentNullException("array");

            int cols = array.GetUpperBound(1) + 1;
            T[] result = new T[cols];

            int size;

            if (typeof(T) == typeof(bool))
                size = 1;
            else if (typeof(T) == typeof(char))
                size = 2;
            else
                size = Marshal.SizeOf<T>();

            Buffer.BlockCopy(array, row * cols * size, result, 0, cols * size);

            return result;
        }

        public static bool IsHaveOnlyUniqueValues(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if(array[i] == array[j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true; 
        }

        public static int indexOfDuplicateValue(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (array[i] == array[j])
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public static int indexOfDuplicateValueWithout(int[] array, int beginWithoutIndex, int endWithoutIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (array[i] == array[j])
                        {
                            if(i < beginWithoutIndex || i >= endWithoutIndex)
                            {
                                return i;
                            }
                            else if(j < beginWithoutIndex || j >= endWithoutIndex)
                            {
                                return j;
                            }
                        }
                    }
                }
            }
            return -1;
        }

        public static void setRow(int[,] multiArray, int[] row, int index)
        {
            for(int i = 0; i < row.Length; i++)
            {
                multiArray[index, i] = row[i];
            }
        }

    }

    enum WriteModeEnum
    {
        NEW,
        APPEND
    }
}
