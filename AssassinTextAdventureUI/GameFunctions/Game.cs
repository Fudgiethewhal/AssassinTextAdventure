using AssassinTextAdventureUI.Character;

namespace AssassinTextAdventureUI.GameFunctions;

public static class Game
{
    public static void RunGame()
    {
        
        UserInteraction.GameDialogue("Welcome to Assassin's Tale!\nLet's start off by getting the name of your assassin.");
        var assassin = new Assassin();
        assassin.Name = UserInteraction.GetUserInput("Enter the name of your character:");
        assassin.Health = StatGeneration.GenerateRandomHealth();
        assassin.AttackDamage = StatGeneration.GenerateRandomAssassinAttack();

        UserInteraction.GameDialogue($"Hello and welcome to the Creed{assassin.Name}, I see you are the new recruit.\nWould you like to ask me something?"); 
        UserInteraction.PlayerInquiry(new string[] {"Who are you?", "What is this place?", "Goodbye"}, new string[] {"I am the commander of this lair. My name isn't relevant.", "This is the great city of Cairo, but danger lurks at every corner..."});
     }
    
}

