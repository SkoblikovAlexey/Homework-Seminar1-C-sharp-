Console.WriteLine("Введите три числа");
float a = Convert.ToInt32(Console.ReadLine());
float b = Convert.ToInt32(Console.ReadLine());
float c = Convert.ToInt32(Console.ReadLine());
float max = a;
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);