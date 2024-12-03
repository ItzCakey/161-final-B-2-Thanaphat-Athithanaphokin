using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string newAnimalName)
    {
        animalName = newAnimalName;
    }

    public abstract float CalculateFoodRequirement();

    public void MakeSound(string sound)
    {
        Debug.Log($"{animalName} says {sound}");
    }
    
    public void DisplayName()
    {
        Debug.Log($"This is {animalName}");
    }
}
