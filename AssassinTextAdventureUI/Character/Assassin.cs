﻿namespace AssassinTextAdventureUI.Character;

public class Assassin : ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Attack()
    {
        return AttackDamage;
    }

    public void TakeDamage(int damage)
    {
        if (Health - damage <= 0)
        {
            Health = 0;
        }
        else Health -= damage;
    }
}