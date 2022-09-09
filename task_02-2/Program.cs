/* Написать программу масштабирования фигуры Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/
Console.WriteLine("Input scaling factor :");
double scalfactor;
while (!double.TryParse(Console.ReadLine(), out scalfactor))//проверка что вводится число
    Console.Write("Неверный ввод! \nВведите значение снова : ");

Console.WriteLine("Input coordinate list :");
string[] strarray = Console.ReadLine()?.Split(' ');
double[] arrayverchin = new double[strarray.Length];
//double[] scalarray = 
for (int i = 0; i < strarray.Length; i++)
    arrayverchin[i] = double.Parse(strarray[i]) * scalfactor;



Console.WriteLine($"Вершины фигуры с учетом коэффициента масштабирования k = {scalfactor}: ");
for (int i = 0; i < (arrayverchin.Length-1); i++)
    {
        Console.Write("({0},{1}) ", arrayverchin[i], arrayverchin[i + 1]);
        i++;
    }
