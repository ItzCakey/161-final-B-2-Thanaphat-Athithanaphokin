using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        base.Cast("Golem");
        base.Cast("Frost Bite!", 15);
    }

    private void Start()
    {
        Cast();
    }
}

