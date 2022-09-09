// Написать программу копирования массива

// Метод ввода массива с клавиатуры
void InputMas(int[] position)
{
    for (int i = 0; i < position.Length; i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        position[i] = int.Parse(Console.ReadLine());
    }
}

// Метод для генерации значений элементов массива (с диапазоном от min до max)
void RandomArrayElement(int[] position, int min, int max)
{
    Random rand = new Random();
    int i = 0;
    while (i < position.Length)
    {
        position[i] = rand.Next(min, max);
        i++;
    }
}
// Метод для вывода на экран элементов массива
void PrintArray(int[] position)
{
    foreach (var element in position)
        Console.Write($"{element} ");
    Console.WriteLine();
}
// Метод  копирования массива
int[] CopyMas(int[] mas)
{
    int[] copyresult = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        copyresult[i] = mas[i];//копирование элементов в др.массив
    };
    return copyresult;
}

Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
int[] array = new int[LengthArray];
InputMas(array);
Console.WriteLine("Скопированный массив :");
int[] copyarray = CopyMas(array);
foreach (var element in copyarray)
    Console.Write($"{element} ");
Console.WriteLine();