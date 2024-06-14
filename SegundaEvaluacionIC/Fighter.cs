using System;

internal class Fighter : Ship
{
    public Fighter() : base("Caza", 100, 'F')
    {
        Attack = 20;
        Weapon = new Laser();
        Shield = new Shield("Escudo de Energia", 5, 50);
    }

    public override void specialAttack(Player target)
    {

    }
}

