using System;

public class Ship : Player
{
    public int modVida;
    public int modAtaque;

    public Ship(string name, float health, char icon) : base(name, health, icon) { }

    public virtual void specialAttack(Player target)
    {

    }

}