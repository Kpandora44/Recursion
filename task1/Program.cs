//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

string GetListNums(int n, int m)
{
if (m > n)
{
   return Convert.ToString(n);
}
{
if (m == n)
   {return Convert.ToString(m);}
   return m + " " + GetListNums(n,m+1);
}
}
Console.Write("Введите число M:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Натуральные числа от M до N: ");
Console.WriteLine(GetListNums(m,n));