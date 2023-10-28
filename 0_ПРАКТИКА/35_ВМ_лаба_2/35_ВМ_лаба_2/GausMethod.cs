using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ВМ_лаба_2
{
    internal class GausMethod
    { 

        // вычисление Кэфа m_i
        public double CalculateM(double Ai, double Aconst)
        {
            return -Ai / Aconst;
        }

        // делаем матрицу треугольной - прямой ход
        public Matrix ConvertMatrixToTriangle(Matrix original)
        {
            for (int i = 0; i < original.Row-1; i++)
            {
                original = CalcMatrixOfM(original, i);
            }

            return original;
        }
        
        // прямой ход
        private Matrix CalcMatrixOfM(Matrix matrix, int column)
        {
            double kf = matrix.array[column, column];
            double m2 = CalculateM(matrix.array[1, column], matrix.array[column, column]);
            double m3 = CalculateM(matrix.array[2, column], matrix.array[column, column]);
            double m4 = CalculateM(matrix.array[3, column], matrix.array[column, column]);

            if(column > 0)
            {
                m2 = 0;
            }
            if(column > 1)
            {
                m2 = 0;
                m3 = 0;
            }
            if(column > 2)
            {
                m2 = 0;
                m3 = 0;
                m4 = 0;
            }
            double[,] mArray = new double[4, 5]
            {
                { 0, 0, 0, 0, 0 },
                { matrix.array[column,0] * m2, matrix.array[column,1] * m2, matrix.array[column,2] * m2, matrix.array[column,3] * m2, matrix.array[column,4] * m2 },
                { matrix.array[column,0] * m3, matrix.array[column,1] * m3, matrix.array[column,2] * m3, matrix.array[column,3] * m3, matrix.array[column,4] * m3 },
                { matrix.array[column,0] * m4, matrix.array[column,1] * m4, matrix.array[column,2] * m4, matrix.array[column,3] * m4, matrix.array[column,4] * m4 },
            };

            Matrix mt = new Matrix(4,5);
            mt.Fill(mArray);
            Matrix res = matrix + mt;
            Console.WriteLine(res.ToString());
            return res;
        }
    }
}
