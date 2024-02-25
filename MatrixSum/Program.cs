int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };

int[] matrix1Dimensions = { matrix1.GetLength(0), matrix1.GetLength(1) };
int[] matrix2Dimensions = { matrix2.GetLength(0), matrix2.GetLength(1) };

if (matrix1Dimensions[0] == matrix2Dimensions[0] && matrix1Dimensions[1] == matrix2Dimensions[1])
{
    Console.WriteLine("São iguais");
} else
{
    Console.WriteLine("Não são iguais");
}

int matrix1Element;
int matrix2Element;

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1Element = matrix1[i, j];
        matrix2Element = matrix2[i, j];
        Console.WriteLine(matrix1Element + matrix2Element);
    }
}