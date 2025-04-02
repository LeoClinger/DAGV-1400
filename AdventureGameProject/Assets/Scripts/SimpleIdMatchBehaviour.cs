using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIdMatchBehaviour : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, mismatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIdBehaviour>();

        if(otherID.id == id)
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID: " + id);
        }
        else
        {
            mismatchEvent.Invoke();
            Debug.Log("Mismatch ID: " + id);
        }
    }
}
