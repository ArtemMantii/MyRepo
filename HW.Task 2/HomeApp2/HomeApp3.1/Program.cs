using System;

namespace HomeApp3._1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of array elements:");

      int elemNum = int.Parse(Console.ReadLine());
      int[] intArray2 = new int[elemNum];

      for (int i = 0; i < intArray2.Length; i++)
      {
        Console.Write($"Enter the array element below the {i}:");
        intArray2[i] = int.Parse(Console.ReadLine());
      }

      int sum = 0;
      for (int x = 0; x < intArray2.Length; x++)
        sum += intArray2[x];
      Console.WriteLine("Ammount of array elements:" + " " + sum);

      int maxValue = intArray2[0];
      for (int x = 0; x < intArray2.Length; x++)
        if (intArray2[x] > maxValue)
          maxValue = intArray2[x];
      Console.WriteLine("The maximum value of an array elements:" +" " + maxValue);

      int minValue = intArray2[0];
      for (int x = 0; x < intArray2.Length; x++)
        if (intArray2[x] < minValue)
          minValue = intArray2[x];
      Console.WriteLine("The minimum value of an array elements:" + " " + minValue);

      //int index = 0;
      //while(index < intArray2.Length)
      //{
      //  Console.WriteLine(intArray2[index]);
      //  index++;
      //}

      //for (int i = 0; i < intArray2.Length; i++)
      //{
      //  Console.WriteLine(i);
      //  int value = intArray2[i];
      //  Console.WriteLine(value);
      //}

      //foreach(int value in intArray2)
      //  Console.WriteLine(value);



      //int[,] intArray3 = new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 7, 6, 5}};
      //for (int i = 0; i < 4; i++)
      //  for (int j = 0; j < 3; j++)
      //  {
      //    Console.WriteLine(i + "-" + j);
      //    Console.WriteLine(intArray3[i, j]);
      //  }


    }
  }
}
