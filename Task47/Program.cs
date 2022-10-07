// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m, n];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            //matr[i, J] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
            matr[i, J] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
        }
    }
}
void PrintArray(double[,] matr)
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
