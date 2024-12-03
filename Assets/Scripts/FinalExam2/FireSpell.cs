using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        base.Cast("Slime");
        base.Cast("Fire Storm!", 20);
    }

    private void Start()
    {
        Cast();
    }
}

