using _1_перегрузка_операторов;

int size = 4;
Matrix matrix1 = new SquareMatrix(size);
Matrix matrix2 = new SquareMatrix(size);

matrix1.Table.Fill(false);
matrix2.Table.Fill(true);

var sumMatrix = matrix1.Table + matrix2.Table;

string example = $"{matrix1.Table.ToString()} + \n{matrix2.Table.ToString()} = \n{sumMatrix.ToString()}";
Console.WriteLine(example);
