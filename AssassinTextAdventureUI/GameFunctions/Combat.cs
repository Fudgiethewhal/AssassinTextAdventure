using AssassinTextAdventureUI.Character;

namespace AssassinTextAdventureUI.GameFunctions;

public static class Combat
{
    public static void KnightVsOneEnemy(Assassin assassin, Enemy enemy)
    {
        while (assassin.Health > 0 && enemy.Health > 0)
        {
            UserInteraction.GameDialogue($"\n{assassin.Name} (Health: {assassin.Health} Attack: {assassin.AttackDamage} vs {enemy.Name}) Health: {enemy.Health} Attack: {enemy.AttackDamage})");
            Thread.Sleep(5000);
            
            UserInteraction.GameDialogue($"{assassin.Name} attacks {enemy.Name}!");
            enemy.TakeDamage(assassin.Attack());
            Thread.Sleep(5000);

            if (enemy.Health <= 0)
            {
                UserInteraction.GameDialogue($"{enemy.Name} has been defeated");
                    Thread.Sleep(5000);
                    break; 
            }
            
            UserInteraction.GameDialogue($"{enemy.Name} attacks {assassin.Name}!");
            assassin.TakeDamage(enemy.Attack());
            Thread.Sleep(5000);
            
            if (assassin.Health <= 0)
            {
                UserInteraction.GameDialogue($"{assassin.Name} has been defeated!");
                Thread.Sleep(5000);
                break; 
            }
        }
    }
}