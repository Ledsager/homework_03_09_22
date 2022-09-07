// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, 
// y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы
int InputParametr()
{
    int Number;
    while (!int.TryParse(Console.ReadLine(), out Number))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите значение снова : ");
    return Number;
}

void InterSection(int k1, int k2, int b1, int b2)
{
    if (k1 != k2)
    {
        Console.WriteLine($"точка пересечения заданных прямых имеет кординаты [{(b2 - b1) / (k1 - k2)},{k1 * ((b2 - b1) / (k1 - k2)) + b1}]");
    }
    else
    {
        Console.WriteLine("прямые с заданными значениями или параллельны или совпадают");
    }

}

int k1, k2, b1, b2;
Console.WriteLine("Введите значения для первой прямой y=k1*x+b1 :");
Console.WriteLine("k1:");
k1 = InputParametr();
Console.WriteLine("b1:");
b1 = InputParametr();
Console.WriteLine("Введите значения для первой прямой y=k2*x+b2 :");
Console.WriteLine("k2:");
k2 = InputParametr();
Console.WriteLine("b2:");
b2 = InputParametr();
InterSection(k1,k2,b1,b2);