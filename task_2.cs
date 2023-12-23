/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

int Akkerman(int n, int m) {
      if (n == 0) return m + 1;
      if (m == 0) return Akkerman(n - 1, 1);
      else return Akkerman(n - 1, Akkerman(n, m - 1));
}

void Main() {
    
    Console.WriteLine("Введите первое число:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int n2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine(Akkerman(n1, n2));
}

Main();
