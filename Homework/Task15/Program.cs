// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели: "); 
int day = Convert.ToInt32(Console.ReadLine()); 
  
if (day == 7 || day == 6){ 
    System.Console.WriteLine("Выходной"); 
} 
else if ((day == 2 || day == 3 || day == 4 || day == 5)){ // || это или
    System.Console.WriteLine("Будний"); 
}
else{ 
    System.Console.WriteLine("Неверный день недели"); 
}