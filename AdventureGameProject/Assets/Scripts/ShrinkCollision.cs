using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkCollision : MonoBehaviour
{
    public float shrinkFactor;

    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkFactor;
    }
}
