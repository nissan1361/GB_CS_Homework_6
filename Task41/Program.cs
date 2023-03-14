// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("*****************");

int result = GetPositiveNumbers(m);
Console.WriteLine($"Чисел больше нуля введено -> {result}");

static int GetPositiveNumbers(int size)
{
    int summ = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1}-ое число: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            summ++;
        }
    }

    return summ;
}