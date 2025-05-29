namespace AssassinTextAdventureUI.GameFunctions;

public class StatGeneration
{
    public static int GenerateRandomHealth()
    {
        return Random.Shared.Next(75, 101);
    }
    
    public static int GenerateRandomAssassinAttack()
    {
        return Random.Shared.Next(20, 35);
    }
    
    public static int GenerateRandomEnemyAttack()
    {
        return Random.Shared.Next(5, 16);
    }
}