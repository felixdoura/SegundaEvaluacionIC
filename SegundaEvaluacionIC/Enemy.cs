using System;

public class Enemy : Character
{
    public Enemy(string name, float maxHealth, float attack) : base(name, maxHealth, 'E')
    {
        Attack = attack;
    }
}