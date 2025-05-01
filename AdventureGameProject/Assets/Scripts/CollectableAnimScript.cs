using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Animations;
using UnityEngine;
using UnityEngine.Events;

public class CollectableAnimScript : MonoBehaviour
{
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

 

    private void OnTriggerEnter(Collider other)
    {
         //collect
         if (other.gameObject.tag == "Player")
         {
             animator.SetTrigger("Collect");
         }
    }
}