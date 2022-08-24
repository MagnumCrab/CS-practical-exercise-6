// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество чисел М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[M];

void EnterNumbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

EnterNumbers(M);
Console.WriteLine($"Введено чисел больше 0: {Comparison(ArrayNumbers)} ");