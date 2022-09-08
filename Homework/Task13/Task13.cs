// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine()); //задаем переменную anyNumber
// string anyNumberText = Convert.ToString(anyNumber); // переводим в ряд чисел
// if (anyNumberText.Length > 2){
//  Console.WriteLine($"третья цифра" + anyNumberText[2]); //тут не ставятся {} внутри совместно с []}
// else {
//  Console.WriteLine("третьей цифры нет");
// }
int n = new Random().Next(100, 10000);
if (n < 100){                           // проверяем на трехзначность
  System.Console.WriteLine("Третьей цифры нет");
}
else{
  int result = n / 100 % 10; // третье число
  System.Console.WriteLine($"Третья цифра цисла {n} --> {result}");
}