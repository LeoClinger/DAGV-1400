using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class SimpleImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
