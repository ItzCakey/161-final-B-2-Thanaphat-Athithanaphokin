using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 5;
    private int weight = 4;

    public override float CalculateFoodRequirement()
    {
        float foodRequirement;
        foodRequirement = dailyFoodConsumption * weight * 7;

        return foodRequirement;
    }

    private void Start()
    {
        Init("Bird");
        DisplayName();
        MakeSound("Jib Jib");
        Debug.Log($"{animalName} eats : {dailyFoodConsumption} and weight is : {weight}");
        Debug.Log($"Weekly food requirement for bird is : {CalculateFoodRequirement()}");
    }
}
