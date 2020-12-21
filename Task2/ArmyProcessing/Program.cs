using System;

namespace ArmyProcessing
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] soldiersAttack = new[] { 2, 2, 2, 5, 5 };
      int[] soldiersHealth = new[] { 20, 20, 20, 10, 10 };
      int[] soldiersType = new[] { 0, 0, 0, 1, 1 };

      Console.WriteLine("Soldiers attack:");
      WriteArrayToConsole(soldiersAttack);

      int bufValue = 5;
      int[] buffedAttack = BufArchers(soldiersAttack, soldiersType, bufValue);
      Console.WriteLine("Buffed soldiers");
      WriteArrayToConsole(buffedAttack);

      int attackValue = 6;
      int[] attackedHealth = AttackArmy(soldiersHealth, soldiersType, attackValue);
      Console.WriteLine("Attacked soldiers");
      WriteArrayToConsole(attackedHealth);
    }

    private static int[] AttackArmy(int[] soldiersHealth, int[] soldiersType, int attackValue)
    {
      // troopers attack value = attackValue/2, archers attack value = attackValue
    }

    private static int[] BufArchers(int[] soldiersAttack, int[] soldiersType, int bufValue)
    {
      int[] buffedAttack = new int[soldiersAttack.Length];
      for (int i = 0; i < soldiersAttack.Length; i++)
        if (soldiersType[i] == 1)
          buffedAttack[i] = soldiersAttack[i] * bufValue;
        else
          buffedAttack[i] = soldiersAttack[i];

      return buffedAttack;
    }

    static void WriteArrayToConsole(int[] intArray)
    {
      foreach (int value in intArray)
        Console.Write(value + " ");
      Console.WriteLine();
    }

  }
}
