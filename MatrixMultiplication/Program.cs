using MatrixMultiplication;

int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] array2 = { { 4, 5, 3 }, { 5, 4, 2 }, { 3, 6, 1 } };

var result = MatrixOperation.MultiplyMatrixes(array1, array2);

MatrixOperation.PrintMatrix(array1);
MatrixOperation.PrintMatrix(array2);
MatrixOperation.PrintMatrix(result);