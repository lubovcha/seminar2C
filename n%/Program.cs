// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.Write("Введите число a: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите число b: "); 
int b = Convert.ToInt32(Console.ReadLine()); 
double result = a%b;

if(a % b == 0){ 
    System.Console.WriteLine($"Число {a} является кратным числу {b}"); 
} 
else{ 
    System.Console.WriteLine($"Число {a} не является кратным числу {b}, остаток от деления {a % b}"); 
}
