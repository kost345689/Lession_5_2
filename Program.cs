//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.Write($"Введи размер массива: ");

int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  
  {

  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;

  Console.Write($"Вывод массива: ");

    for (int i = 0; i <numberElements; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");

      if ((randomNumbers[i]%2)!=0)
      {
        sumElements = sumElements + randomNumbers[i];
      }

    }

  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма нечетных элементов: {randomNumbers}");















