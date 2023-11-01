using _35_ВМ_лаба_2;

static void Main(string[] args)
{
    #region Gaus
    /*
    // начальное заполнение
    GausMethod gausMethod = new GausMethod();
    double[,] baseGausMatrix = new double[4, 5]
    {
        { 2, 1, -0.1, 1, 2.7 },
        { 0.4, 0.5, 4, -8.5, 21.9 },
        { 0.3, -1, 1, 5.2, -3.9 },
        { 1, 0.2, 2.5, -1, 9.9 }
    };

    Matrix matrix = new Matrix(4, 5);
    matrix.Fill(baseGausMatrix);

    // прямой ход
    Matrix triangleMatrix = gausMethod.ConvertMatrixToTriangle(matrix);
    gausMethod.CalculateRoot(triangleMatrix);*/
    #endregion

    ZaidelMethod zaidelMethod = new ZaidelMethod();
    zaidelMethod.CalcApproximation();
}

Main(new string[0]);