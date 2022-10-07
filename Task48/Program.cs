// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = i + J;
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            Console.Write($"{matr[i, J]} ");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
