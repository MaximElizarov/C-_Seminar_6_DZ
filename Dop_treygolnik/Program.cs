Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine()); 
double s = 0;

s = -0.5 * ((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1));
Console.WriteLine($"Площадь треугольника равна: {s}");

// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

// Примеры
// №	INPUT.TXT	OUTPUT.TXT
// 1	2 1 2 4 6 1	6
// 2	0 0 0 3 3 0	4.5