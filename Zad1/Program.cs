// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B (3, 5 -> 243 (3⁵);  2, 4 -> 16). 

int firstNumber = ReadInt("Введите число А: ");
int secondNumber = ReadInt("Введите число В (число >= 0): ");
int exponentiation = 1;

for (int i = 1; i <= secondNumber && secondNumber >= 0; i++)
{
    exponentiation = firstNumber * exponentiation;
}

Console.WriteLine(firstNumber + "^" + secondNumber + "=" + exponentiation);

if (secondNumber < 0)
{
    Console.WriteLine("Число неверно, введите положительное число");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
