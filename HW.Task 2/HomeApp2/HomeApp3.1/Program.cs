using System;

namespace HomeApp3._1
{
  class Program
  {
    static int ReadIntValueFromConsole(string message)
    {
      while (true)
      {
        Console.WriteLine(message);
        string inputValue = Console.ReadLine();

        int intValue;
        bool validValue = int.TryParse(inputValue, out intValue);

        if (validValue)
          return intValue;
      }
    }
    static int ReadIntValueFromConsole(string message, int minValue, int maxValue)
    {
      while (true)
      {
        Console.WriteLine(message);
        string inputValue = Console.ReadLine();

        int intValue;
        bool validValue = int.TryParse(inputValue, out intValue);
        if (!validValue)
          continue;

        validValue = intValue >= minValue && intValue <= maxValue;
        if (validValue)
          return intValue;
      }
    }
    static int[] GetEmptyArrayFromConsole()
    {
      int elemNum = ReadIntValueFromConsole("Enter the number of array elements:", 3, 10);
      return new int[elemNum];
    }
    static int[] GetArrayFromConsole()
    {
      int[] intArray = GetEmptyArrayFromConsole();

      for (int i = 0; i < intArray.Length; i++)
        intArray[i] = ReadIntValueFromConsole($"Enter the array element below the {i}:", -100, 100);
      return intArray;
    }
    static int[] GetPredifinedArray()
    {
      return new int[] { 1, -3, 5, -6, 10, -35, 8 };
    }

    static int GetSum(int[] intArray)
    {
      int sum = 0;
      for (int x = 0; x < intArray.Length; x++)
        sum += intArray[x];
      return sum;
    }
    static int GetMaxValue(int[] intArray)
    {
      int maxValue = intArray[0];
      for (int x = 0; x < intArray.Length; x++)
        if (intArray[x] > maxValue)
          maxValue = intArray[x];
      return maxValue;
    }
    static int GetMinValue(int[] intArray)
    {
      int minValue = intArray[0];
      for (int x = 0; x < intArray.Length; x++)
        if (intArray[x] < minValue)
          minValue = intArray[x];
      return minValue;
    }
    static int GetPositiveElementsCount(int[] intArray)
    {
      int positiveNum = 0;
      foreach (int number in intArray)
        if (number > 0)
          positiveNum++;
      return positiveNum;
    }
    static int[] GetPositiveElements(int[] intArray)
    {
      int[] intArray2 = new int[intArray.Length];
      int currentIndex = 0;
      foreach (int element in intArray)
        if (element > 0)
          intArray2[currentIndex++] = element;

      int[] resultArray = new int[currentIndex];
      for (int i = 0; i < resultArray.Length; i++)
        resultArray[i] = intArray2[i];

      return resultArray;
    }
    static int[] MultiplyArray(int[] intArray)
    {
      int[] intArray2 = new int[intArray.Length];
      for (int i = 0; i < intArray.Length; i++)
        intArray2[i] = intArray[i] * 2;
      return intArray2;
    }
    static void WriteArrayToConsole(int[] intArray)
    {
      foreach (int value in intArray)
        Console.Write(value + " ");
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      //int[] intArray = GetArrayFromConsole();
      int[] intArray = GetPredifinedArray();
      Console.WriteLine("The original array");
      WriteArrayToConsole(intArray);

      int[] positiveArray = GetPositiveElements(intArray);
      Console.WriteLine("Positive elements");
      WriteArrayToConsole(positiveArray);

      int sum = GetSum(intArray);
      Console.WriteLine($"Amount of array elements: {sum}");

      int maxValue = GetMaxValue(intArray);
      Console.WriteLine($"The maximum value of an array elements: {maxValue}");

      int minValue = GetMinValue(intArray);
      Console.WriteLine($"The minimum value of an array elements: {minValue}");

      int positiveNum = GetPositiveElementsCount(intArray);
      Console.WriteLine($"Count of positive elements: {positiveNum}");

      int[] multipliedArray = MultiplyArray(intArray);
      Console.WriteLine("Multiplied elements");
      WriteArrayToConsole(multipliedArray);









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
