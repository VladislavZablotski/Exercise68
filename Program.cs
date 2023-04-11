int ack(int n, int m)
{
   if (n == 0)
     return m + 1;
   else if (m == 0)
     return ack (n - 1, 1);
   else
     return ack(n - 1, ack (n, m - 1));
}

Console.WriteLine("Введите число M");
int M =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N =int.Parse(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана при M = {M} и N = {N} равно {ack(M,N)}");