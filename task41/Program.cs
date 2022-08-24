// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите через пробел M чисел: ");
int[] massiv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int j = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] > 0)
    {
        j++;
    }
}
Console.WriteLine($"Количество положительных элементов: {j}");