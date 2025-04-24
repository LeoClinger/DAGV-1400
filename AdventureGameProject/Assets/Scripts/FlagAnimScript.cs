using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Unity.VisualScripting;

public class FlagAnimScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //flag up
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("PullFlag");
        }
    }
}
