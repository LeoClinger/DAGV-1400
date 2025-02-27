using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float value;

    public void UptateValue(float amount)
    {
        value += amount;
    
    }

    public void SetValue(float amount)
    {
        value = amount;
    }
}
