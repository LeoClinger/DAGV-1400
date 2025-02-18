using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransform : MonoBehaviour
{
    public float direction1 = 0, direction2 = 180;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if (!Input.GetKeyDown(KeyCode.A)) return;
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }
}
