// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int stringArr = new Random().Next(3, 10);
int columnArr = new Random().Next(3, 10);


int[,] matrix = new int[stringArr, columnArr];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = new Random().Next(-10, 10);
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

Console.Write("Введите номер строки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int l = Convert.ToInt32(Console.ReadLine());

if(k <= stringArr & l <= columnArr) Console.WriteLine(matrix[k-1, l-1]);
else Console.WriteLine("Такого числа в массиве нет!");


