// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Сколько чисел Вы хотите ввести? ");
int size = int.Parse(Console.ReadLine());
int[] array = FillArray (size);

Console.Write($"[{string.Join(", ",array)}] -> ");
Console.Write(CountPositiveNumber (array));


int[] FillArray (int value)
{
int[] array = new int [value];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    array[i] = int.Parse(Console.ReadLine());
}
return array;
}

int CountPositiveNumber (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
