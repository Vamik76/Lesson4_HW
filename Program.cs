// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine ("Введите первое чиcло");
double a = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine ("Введите второе чиcло");
double b = Convert.ToDouble (Console.ReadLine ());
double c=Math.Pow(a,b);
Console.WriteLine(c);