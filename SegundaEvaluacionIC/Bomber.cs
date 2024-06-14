using System;

internal class Bomber : Ship
{
    public Bomber() : base("Bombardero", 100, 'B')
    {
        Attack = 20;
        Weapon = new ProtonTorpedo();
        Shield = new Shield("Escudo Reforzado", 10, 40);
    }

    public override void specialAttack(Player target)
    {

    }
}

