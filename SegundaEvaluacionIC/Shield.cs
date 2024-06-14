using System;

public class Shield
{
    public string Name { get; private set; }
    public float Defense { get; private set; }
    public float ShieldEnergy { get; private set; }

    public Shield(string name, float defense, float shieldEnergy)
    {
        Name = name;
        Defense = defense;
        ShieldEnergy = shieldEnergy;
    }

    public float MitigateDmg(float damage)
    {
        float mitigatedDamage = damage - Defense;
        if (mitigatedDamage < 0)
        {
            mitigatedDamage = 0;
        }

        ShieldEnergy -= mitigatedDamage;
        if (ShieldEnergy < 0)
        {
            ShieldEnergy = 0;
        }

        return mitigatedDamage;
    }
}