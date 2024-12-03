using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 6;
    private int activityLevel = 5;

    public override float CalculateFoodRequirement()
    {
        float foodRequirement;
        foodRequirement = dailyFoodConsumption * activityLevel * 7;

        return foodRequirement;
    }

    private void Start()
    {
        Init("Dog");
        DisplayName();
        MakeSound("Bark Bark");
        Debug.Log($"{animalName} eats : {dailyFoodConsumption} and activity level is : {activityLevel}");
        Debug.Log($"Weekly food requirement for dog is : {CalculateFoodRequirement()}");
    }
}
