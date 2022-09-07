// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// мой вариат

// Console.Write("Введите число: "); 
// int a = Convert.ToInt32(Console.ReadLine()); 

// int b = 7;
// int c = 23;

// if(a % b == 0){ 
//    System.Console.WriteLine($"Число {a} является кратным числу {b}"); 
// } 
// else{ 
//    System.Console.WriteLine($"Число {a} не является кратным числу {b}"); 
// }
// if(a % c == 0){ 
//    System.Console.WriteLine($"Число {a} является кратным числу {c}"); 
// } 
// else{ 
//    System.Console.WriteLine($"Число {a} не является кратным числу {c}"); 
// }

// вариант препода 

int a = 161;

if (a % 7 == 0){
    if (a % 23 ==0){
    System.Console.WriteLine("делится");    
    }
}
else{
    System.Console.WriteLine("не делится");
}