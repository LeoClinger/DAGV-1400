using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Events;

public class CollectableAnimScript : MonoBehaviour
{
    private Animator animator;
    private Collider other;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        CollectAnimations();
    }

    private void CollectAnimations()
    {
        //collect
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("Collect");
        }
    }
}