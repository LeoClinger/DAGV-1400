using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CollectableTriggerEventScript : MonoBehaviour
{
    
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerEvent.Invoke();
            //Destroy(gameObject);
        }
    }
}

