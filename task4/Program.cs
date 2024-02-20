Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Цифры числа " + N + " через запятую: ");
int divider = 1;
while (N / divider >= 10)
{
    divider *= 10;
}
while (divider > 0)
{
    int digit = N / divider;
    Console.Write(digit);
    N %= divider;
    divider /= 10;
    if (divider > 0)
    {
         Console.Write(", ");
    }
}



