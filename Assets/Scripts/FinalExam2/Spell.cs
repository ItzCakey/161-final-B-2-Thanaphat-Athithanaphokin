using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
   public virtual void Cast()
    {
        Debug.Log("Start spell casting!");
    }

    public void Cast(string castToEnemy)
    {
        Debug.Log($"Spell is being used on {castToEnemy}");
    }

    public void Cast(string spellName, int powerLevel)
    {
        Debug.Log($"Casting spell is {spellName}, with power level of {powerLevel}");
    }
}
