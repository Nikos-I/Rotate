// Написать алгоритм поворота матрицы [N;N] на 90 градусов

int n = 6; // Размерность матрицы
int[,] matrixSource = new int[n, n];
int[,] matrixDestination = new int[n, n];

void FillMatrix(ref int[,] arraySrc)
{
    int n = arraySrc.GetUpperBound(0) + 1;
    {
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                arraySrc[i, j] = 0;
            }
        for (int i = 0; i < n / 2; i++)
        {
            arraySrc[i, n - i - 1] = 11;
        }
    }

}

void PrintMatrix(ref int[,] matrixSrc)
{
    for (int i = 0; i <= matrixSrc.GetUpperBound(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j <= matrixSrc.GetUpperBound(1); j++)
        {
            System.Console.Write($"{matrixSrc[i, j]:D2} ");
        }
    }
    System.Console.WriteLine();
}

// Поворот матрицы на 90 градусов
void RotateMatrix90(ref int[,] matrixSrc, string direction)
// direction: CW - по часовой стрелке, CCW - против часовой стрелки

{
    int[,] matrixDst = new int[matrixSrc.GetUpperBound(0) + 1, matrixSrc.GetUpperBound(1) + 1]; // Временная матрица
    int n = matrixSrc.GetUpperBound(0) + 1;

    // Транспонирование Src -> Dst
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            matrixDst[j, i] = matrixSrc[i, j];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            if (direction == "CW")
                matrixSrc[j, i] = matrixDst[j, n - i - 1]; // Зеркальное отображение Dst -> Src по вертикальой оси
            else if (direction == "CCW")
                matrixSrc[i, j] = matrixDst[n - i - 1, j]; // Зеркальное отображение Dst -> Src по горизонтальной оси
    return;
}

FillMatrix(ref matrixSource);
PrintMatrix(ref matrixSource);

RotateMatrix90(ref matrixSource, "CW");
PrintMatrix(ref matrixSource);

RotateMatrix90(ref matrixSource, "CW");
PrintMatrix(ref matrixSource);

RotateMatrix90(ref matrixSource, "CCW");
PrintMatrix(ref matrixSource);

RotateMatrix90(ref matrixSource, "CCW");
PrintMatrix(ref matrixSource);
