/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.
*/

void listNumber(int a, int b) {
    if (a > b) {
        int tmp = a;
        a = b;
        b = tmp;
    }
    if (a == b) {
        Console.WriteLine(a);
    } else {
        Console.WriteLine(a);
        listNumber(a + 1, b);
    }
}
void Main() {
    
    Console.WriteLine("Введите первое число:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int n2 = int.Parse(Console.ReadLine());
    
    listNumber(n1, n2);
}

Main();
