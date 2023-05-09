// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// System.Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine());

// int getsum(int number) {
// int sum = 0;
// for (int i = 1; i <= A; i++) {
//     sum += i;
//     return sum;
// }
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {A}^ {getsum(A)}");


// Decision of Homework 4. Task 1.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine($"Homework 4. Task 1");
// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     return result;
// }
//   Console.Write("Enter number A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Enter number B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());
//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Answer is: " + exponentiation);


// Decision of Homework 4. Task 2.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine($"Homework 4. Task 2.");
// Console.Write("Enter number N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
//   int SumNumber(int numberN){
//         int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }
// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Total amount of entered numbers: " + sumNumber);

// Decision of Homework 4. Task 3. 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"Homework 4. Task 3");
Console.Write("Enter the row of numbers, separated comma : ");
string? seriesOfNumbers = Console.ReadLine();
seriesOfNumbers = seriesOfNumbers + ",";    
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}
void СheckNumber2 (int  series){
      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Mistake of inserted symbol. Enter digits only.");
      }
}
int[] ArrayOfNumbers(string seriesNew){ 
  int[] arrayOfNumbers = new int[1];    
  int j =0;
  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";
    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}
// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);