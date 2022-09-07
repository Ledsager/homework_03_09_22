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
/*
int[] copyarray = new int[LengthArray];//второй способ
int i = 0;//второй способ
*/
//RandomArrayElement(array, -10, 10);
Console.WriteLine("Сгенерированный массив :");
PrintArray(array);
InputMas(array);
Console.WriteLine("Скопированный массив :");
PrintArray(CopyMas(array));
/*
//второй способ
foreach (var element in array)
    {
        copyarray[i] = element;
        i++;
    }
Console.WriteLine("массив (второй вариант) :");
PrintArray(copyarray);
*/

