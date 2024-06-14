using System;



public class Player : Character
{
    public Player(string name, float maxHealth, char icon) : base(name, maxHealth, icon)
    {
    }

    public void SwitchShip(Character newShip)
    {
        Name = newShip.Name;
        MaxHealth = newShip.MaxHealth;
        Health = newShip.MaxHealth;
        Attack = newShip.Attack;
        Icon = newShip.Icon;
        Weapon = newShip.Weapon;
        Shield = newShip.Shield;
    }
}