using System;

public class Consular : Ship
{
    public Consular() : base("Consular", 100, 'C')
    {
        Attack = 20;
        // Asignar arma y escudo
        Weapon = new ConcussionMissile();
        Shield = new Shield("Escudo Deflector", 8, 60);
    }
}

