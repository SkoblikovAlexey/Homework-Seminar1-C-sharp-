bool check = true;
while (check)
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++) 
{
 int a = i % 2;
    if (a == 0)
    {
        Console.Write(i + ", ");
    }
}
    Console.WriteLine("Введите 'end' для завершения, для продолжения - любой символ");
    string c = Console.ReadLine();
    if (c == "end")
    {
        check = false;
    }
}