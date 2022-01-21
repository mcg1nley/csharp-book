using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Weapon weapon;

    public Mage(string name, Weapon weapon): base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("{0} we are humbled to be in your presence. May your {1} guide you!", name, weapon.name);
    }

}
