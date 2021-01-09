using System;

namespace ArmyProcessing
{
  class Program
  {
    enum SoldierType
    {
      Trooper,
      Archer,
      Knight
    }

    static void Main(string[] args)
    {
      SoldierType[] soldiersType = GetArmyType();

      int[] soldiersHealth;
      int[] soldiersAttack;
      InitializeArmy(soldiersType, out soldiersHealth, out soldiersAttack);

      Console.WriteLine("Soldiers attack:");
      WriteArrayToConsole(soldiersAttack);
      Console.WriteLine();


      Console.WriteLine("Soldiers type:");
      WriteArrayToConsole(soldiersType);
      Console.WriteLine();

      Console.WriteLine("Soldiers Health:");
      WriteArrayToConsole(soldiersHealth);
      Console.WriteLine();
      Console.WriteLine();

      int bufValue = 5;
      BufArchers(soldiersAttack, soldiersType, bufValue);
      Console.WriteLine("Buffed soldiers");
      WriteArrayToConsole(soldiersAttack);
      Console.WriteLine();

      int attackValue = 6;
      AttackArmy(soldiersHealth, soldiersType, attackValue);
      Console.WriteLine("Attacked soldiers health");
      WriteArrayToConsole(soldiersHealth);
    }

    private static void InitializeArmy(SoldierType[] soldiersType, out int[] soldiersHealth, out int[] soldiersAttack)
    {
      const int TROOPER_HEALTH = 20;
      const int ARCHER_HEALTH = 10;
      const int KNIGHT_HEALTH = 40;
      const int TROOPER_ATTACK = 2;
      const int ARCHER_ATTACK = 10;
      const int KNIGHT_ATTACK = 5;


      soldiersHealth = new int[soldiersType.Length];
      soldiersAttack = new int[soldiersType.Length];

      for (int i = 0; i < soldiersType.Length; i++)
        switch (soldiersType[i])
        {
          case SoldierType.Trooper:
            soldiersHealth[i] = TROOPER_HEALTH;
            soldiersAttack[i] = TROOPER_ATTACK;
            break;
          case SoldierType.Archer:
            soldiersHealth[i] = ARCHER_HEALTH;
            soldiersAttack[i] = ARCHER_ATTACK;
            break;
          case SoldierType.Knight:
            soldiersHealth[i] = KNIGHT_HEALTH;
            soldiersAttack[i] = KNIGHT_ATTACK;
            break;
        }
    }

    private static SoldierType[] GetArmyType()
    {
      return new[] {
        SoldierType.Trooper,
        SoldierType.Trooper,
        SoldierType.Knight,
        SoldierType.Archer,
        SoldierType.Archer};
    }
    private static SoldierType[] GetArmyTypeFromConsole()
    {
      // Get soldiers count (3-10)
      // get soldier type (0,1,2) in loop
      return new[] {SoldierType.Archer};
    }


    private static void AttackArmy(int[] soldiersHealth, SoldierType[] soldiersType, int attackValue)
    {    
      for (int i = 0; i < soldiersHealth.Length; i++)
      {
        if (soldiersType[i] == SoldierType.Archer)
          soldiersHealth[i] = soldiersHealth[i] - attackValue;
        else 
          if (soldiersType[i] == SoldierType.Knight)
          soldiersHealth[i] = soldiersHealth[i] - attackValue / 3;
          else
          soldiersHealth[i] = soldiersHealth[i] - attackValue / 2;
      }
    }

    private static void BufArchers(int[] soldiersAttack, SoldierType[] soldiersType, int bufValue)
    {
      for (int i = 0; i < soldiersAttack.Length; i++)
        if (soldiersType[i] == SoldierType.Archer)
          soldiersAttack[i] = soldiersAttack[i] * bufValue;
    }

    static void WriteArrayToConsole(int[] intArray)
    {
      foreach (int value in intArray)
        Console.Write(value + " ");
      Console.WriteLine();
    }
    static void WriteArrayToConsole(SoldierType[] soldiersArray)
    {
      foreach (SoldierType value in soldiersArray)
        Console.Write(value + " ");
      Console.WriteLine();
    }

  }
}
