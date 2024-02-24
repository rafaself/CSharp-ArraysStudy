namespace MatrixMultiplication;

public class MatrixOperation
{
    public static List<List<int>> MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
    {
        var matrix1Rows = matrix1.GetLength(0);
        var matrix1Columns = matrix1.GetLength(1);
        var matrix2Rows = matrix2.GetLength(0);
        var matrix2Columns = matrix2.GetLength(1);

        int sum;
        List<List<int>> result = [];
        List<int> partialRowResult = [];

        if (matrix1Columns != matrix2Rows)
        {
            Console.WriteLine($"Não é possível fazer a operação. Pois o array1 possui {matrix1Columns} linhas e o array2 possui {matrix2Rows} colunas.");
        }
        else
        {
            for (int i = 0; i < matrix1Rows; i++)
            {
                partialRowResult = [];
                for (int j = 0; j < matrix2Columns; j++)
                {
                    sum = 0;
                    for (int k = 0; k < matrix1Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    partialRowResult.Add(sum);
                }
                result.Add(partialRowResult);
            }
        }

        return result;
    }

    public static void PrintMatrix(List<List<int>> matrix, string? identifier = "")
    {
        string lineString;
        Console.WriteLine($"-- Matriz {identifier}");
        foreach (var line in matrix)
        {
            lineString = "| ";
            foreach (var column in line)
            {
                lineString += column + " ";
            }
            lineString += "|";
            Console.WriteLine(lineString);
        }
    }

    public static void PrintMatrix(int[,] matrix, string identifier = "")
    {
        Console.WriteLine($"-- Matriz {identifier}");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string lineString = "| ";
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                lineString += matrix[i, j] + " ";
            }
            lineString += "|";
            Console.WriteLine(lineString);
        }
    }
}
