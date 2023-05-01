using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_перегрузка_операторов
{
    internal abstract class Matrix
    {
        public MatrixTable Table { get; private set; }
        public Matrix(int size)
        {
            Table = new MatrixTable(size);
        }
    }
}
