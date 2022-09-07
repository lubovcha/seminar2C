// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Console.Write("Введите число a: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число b: "); 
// int b = Convert.ToInt32(Console.ReadLine()); 
// или:
// Console.Write("Введите 2 числа: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// int b = Convert.ToInt32(Console.ReadLine()); 
//
// if (a * a == b){ //или if (Math.Sqrt(a) == b){
//  System.Console.WriteLine($"Число {a} является квадратом числа {b}");
// }
// else{
//    System.Console.WriteLine($"Число {a} не является квадратом числа {b}");
// }
//
// вариант препода (проверка и числа a и числа b)
//
Console.Write("Введите число a: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число b: "); 
int b = Convert.ToInt32(Console.ReadLine()); 

if (a * a == b){ //или if (Math.Sqrt(a) == b){
   System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else if (b *b == a){
    System.Console.WriteLine($"Число {b} является квадратом числа {a}");
}
else{
    System.Console.WriteLine("Не является квадратом");
}
