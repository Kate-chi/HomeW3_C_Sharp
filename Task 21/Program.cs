int ax = InputNum("Введите X точки А: ");
int ay = InputNum("Введите Y точки А: ");
int az = InputNum("Введите Z точки А: ");

int bx = InputNum("Введите X точки B: ");
int by = InputNum("Введите Y точки B: ");
int bz = InputNum("Введите Z точки B: ");


int xLegSqrt = (ax - bx) * (ax - bx);
int yLegSqrt = (ay - by) * (ay - by);
int zLegSqrt = (az - bz) * (az - bz);

double distance = Math.Sqrt(xLegSqrt + yLegSqrt + zLegSqrt);

Console.Write($"Расстояние между задаными точками в 3D простанстве = {distance}");


int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
