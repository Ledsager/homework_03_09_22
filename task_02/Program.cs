/* Написать программу масштабирования фигуры Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/
Console.WriteLine("Input scaling factor :");
double scalfactor;
    while (!double.TryParse(Console.ReadLine(), out scalfactor))//проверка что вводится число
        Console.Write("Неверный ввод! \nВведите значение снова : ");
Console.WriteLine("Input coordinate list (example: (0,0) (2,0) (2,2) (0,2) (0,0) (0,4) ) :");
string strokavershin = Console.ReadLine();
string koordinate = "";
strokavershin = strokavershin + " ";
int i = 0;
do
{

    koordinate = "";
    while ((Convert.ToString(strokavershin[i]) != " ") && (Convert.ToString(strokavershin[i]) != "(") &&
            (Convert.ToString(strokavershin[i]) != ")") && (Convert.ToString(strokavershin[i]) != ","))
    {
        koordinate = koordinate + strokavershin[i].ToString();
        i++;
    }
    double j;
    if (double.TryParse(koordinate, out j) == true)
    {
        double b = double.Parse(koordinate);
        Console.Write(b * scalfactor);
        Console.Write(strokavershin[i]);
    }
    else
        Console.Write(strokavershin[i]);
    i++;
}
while (i < strokavershin.Length);
