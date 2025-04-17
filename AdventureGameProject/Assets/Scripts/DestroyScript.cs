using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private Collider myCollider;

void Start()
{
    myCollider = GetComponent<Collider>();
}
 
public void Destoryer()
    {
            Destroy(myCollider);
            Destroy(gameObject, 1f);
    }
}
