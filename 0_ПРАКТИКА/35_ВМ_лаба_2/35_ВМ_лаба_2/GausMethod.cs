using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ВМ_лаба_2
{
    internal class GausMethod
    { 
        // обратный ход гауса находим корни
        public void CalculateRoot(Matrix triangleMatrix)
        {
            double x1, x2, x3, x4;
            x4 = triangleMatrix.array[3, 4] / triangleMatrix.array[3, 3];
            x3 = (triangleMatrix.array[2, 4] - (triangleMatrix.array[2, 3] * x4)) / triangleMatrix.array[2, 2];
            x2 = (triangleMatrix.array[1, 4]-(triangleMatrix.array[1, 2]*x3)-(triangleMatrix.array[1, 3]*x4)) / triangleMatrix.array[1, 1];
            x1 = (triangleMatrix.array[0, 4]-x2-(triangleMatrix.array[0, 2]*x3)-x4) / triangleMatrix.array[0, 0];

            x4 = Math.Round(x4, 4);
            x3 = Math.Round(x3, 4);
            x2 = Math.Round(x2, 4);
            x1 = Math.Round(x1, 4);

            Console.WriteLine($"Ответ: x1={x1}; x2={x2}; x3={x3}; x4={x4};");
        }

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
