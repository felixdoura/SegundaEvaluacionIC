using System;

public class Character
{
    public string Name { get; set; }
    public char Icon { get; set; }
    public Weapon Weapon { get; set; }
    public Shield Shield { get; set; }
    public float MaxHealth { get; set; }
    public float Health { get; set; }
    public float Attack { get; set; }

    public Character(string name, float maxHealth, char icon)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = MaxHealth;
        Icon = icon;
    }

    public void SetWeapon(Weapon weapon)
    {
        Weapon = weapon;
    }

    public void SetShield(Shield shield)
    {
        Shield = shield;
    }

    public virtual void Atacar(Character target)
    {
        float damage = Attack + (Weapon?.Attack ?? 0);
        float mitigatedDamage = target.Shield != null ? target.Shield.MitigateDmg(damage) : damage;

        Console.WriteLine($"{Name} ataca a {target.Name} y le causa {mitigatedDamage} de dano.");
        target.Health -= mitigatedDamage;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}