// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine()); //задаем переменную anyNumber
string anyNumberText = Convert.ToString(anyNumber); // переводим в ряд чисел
if (anyNumberText.Length > 2){
  Console.WriteLine($"третья цифра" + anyNumberText[2]); //тут не ставятся {} внутри совместно с []
}
else {
  Console.WriteLine("третьей цифры нет");
}