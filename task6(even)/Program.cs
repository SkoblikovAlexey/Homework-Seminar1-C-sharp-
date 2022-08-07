bool check = true;
while (check) {
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;
if (b == 0) {
    Console.WriteLine("Число " + a + " чётное");
}
else {
    Console.WriteLine("Число " + a + " нечётное");
}
Console.WriteLine("Введите 'end' для выхода, для продолжения - любой символ");
string c = Console.ReadLine();
if (c == "end"){
    check = false;
}
}