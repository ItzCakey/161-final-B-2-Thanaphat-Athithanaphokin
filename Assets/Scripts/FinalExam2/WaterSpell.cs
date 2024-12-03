using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        base.Cast("Godly Anomaly");
        base.Cast("Waterfall!", 10);
    }

    private void Start()
    {
        Cast();
    }
}
