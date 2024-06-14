using System;

public class Weapon
{
    public string Name { get; private set; }
    public float Attack { get; private set; }
    public int CritRate { get; private set; }
    public float CritDmg { get; private set; }

    public Weapon(string name, float attack, int critRate = 10, float critDmg = 2.0f)
    {
        Name = name;
        Attack = attack;
        CritRate = critRate;
        CritDmg = critDmg;
    }

    public float GetAttackDmg(AttackType attackType, bool isCrit)
    {
        float baseDmg = Attack;
        if (attackType == AttackType.Heavy)
        {
            baseDmg *= 1.5f;
        }

        if (isCrit)
        {
            baseDmg *= CritDmg;
        }

        return baseDmg;
    }
}

public enum AttackType
{
    Normal,
    Heavy,
    Special
}