// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int stringArr = new Random().Next(3, 10);
int columnArr = new Random().Next(3, 10);

int[,] Arr = new int[stringArr, columnArr];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = new Random().Next(0, 10);
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
FillArray(Arr);
PrintArray(Arr);

double sum = 0;
double sumAverage = 0;
for (int j = 0; j < Arr.GetLength(1); j++)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        sum = sum + Arr[i, j];
        sumAverage = Math.Round((sum /stringArr), 1);
    }
    Console.Write($"{sumAverage} ");
    sumAverage = 0;
    sum = 0;
}