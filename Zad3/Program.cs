// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19] 
// 3 -> [6, 1, 33]

Console.Write("Введите любое число (количество элементов массива): ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}