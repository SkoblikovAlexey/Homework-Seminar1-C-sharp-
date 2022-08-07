Console.WriteLine("Введите первое и второе числа");
float a = Convert.ToInt32(Console.ReadLine());
float b = Convert.ToInt32(Console.ReadLine());
float min = a;
float max = a;
if (a > b)
{
    min = b;
    max = a;
    Console.Write("Наименьшее число: ");
    Console.WriteLine(min);
    Console.Write("Наибольшее число: ");
    Console.WriteLine(max);
}
else if (a < b)
{
    min = a;
    max = b;
    Console.Write("Наименьшее число: ");
    Console.WriteLine(min);
    Console.Write("Наибольшее число: ");
    Console.WriteLine(max);
}

else
{
    Console.WriteLine("Числа равны");
}