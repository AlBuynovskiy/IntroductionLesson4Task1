// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход два числа (А и В) и метод который возводит число А
в натуральную степень В. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow().
*/

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine($"Число {numberA} возведенное в степень {numberB} принимает значение {exponentiation}");
  