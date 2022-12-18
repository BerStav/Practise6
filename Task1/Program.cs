// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Please, enter the several numbers separated by space: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int amount = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        amount++;
    }
}

Console.WriteLine($"amount of numbers greater than zero : {amount}");