using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_перегрузка_операторов
{
    internal class MatrixTable
    {
        private int _size;
        public int[ , ] Data { get; private set; }

        public MatrixTable(int size)
        {
            _size = size;
            Data = new int[size,size];
        }

        // сама перегрузка
        public static MatrixTable operator + (MatrixTable table1, MatrixTable table2)
        {
            int size = table1._size;
            var result = new MatrixTable(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result.Data[i, j] = table1.Data[i, j] + table2.Data[i, j];
                }
            }

            return result;
        }

        public void Fill(bool isRandom)
        {
            var rnd = new Random();
            if (isRandom)
            {
                for (int i = 0; i < _size; i++)
                {
                    for (int j = 0; j < _size; j++)
                    {
                        Data[i, j] = rnd.Next(0,10);
                    }
                }
            }
            else
            {
                for (int i = 0; i < _size; i++)
                {
                    for (int j = 0; j < _size; j++)
                    {
                        Data[i, j] = 1;
                    }
                }
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < _size; i++)
            {
                var str = string.Empty;
                for (int j = 0; j < _size; j++)
                {
                    str += Convert.ToString(Data[i, j]);
                    str += " ";
                }
                result += $"{str}\n";
            }
            return result;
        }

        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                var str = string.Empty;
                for(int j = 0; j < _size; j++)
                {
                    str += Convert.ToString(Data[i,j]);
                    str += " ";
                }
                Console.WriteLine(str);
            }
        }

    }
}
