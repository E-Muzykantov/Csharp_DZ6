// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

int equation1 = 1;
int equation2 = 2;

double[] way1 = FillArray (equation1);
double[] way2 = FillArray (equation2);

if (Ways(way1, way2))
Console.WriteLine($"({String.Join(", ",FindCrossPoint(way1, way2))})");

double InputNumber()
{
Console.Write("");
int number = int.Parse(Console.ReadLine());
return number;
}


double[] FillArray (int equation)
{
    double[] way = new double[2];
    for (int i = 0; i < way.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число для уравнения № {equation} ");
        way[i] = InputNumber();
    }

return way;
}


double[] FindCrossPoint (double[] way1, double[] way2)
{
    double[] crossPoint = new double [2];
    crossPoint[0] = (way2[1] - way1[0]) / (way1[0] - way2[1]);
    crossPoint[1] = way1[0] * crossPoint[0] + way1[1];
    
    return crossPoint;
}

bool Ways (double[] way1, double[] way2)
{
    if (way1[0] == way2[0] && way1[1] == way2[1])
    {
        Console.Write("Линии совпали");
        return false;
    }
    if (way1[0] == way2[0] && way1[1] != way2[1])
    {
        Console.Write("Линии параллельны");
        return false;
    }
    return true;
}