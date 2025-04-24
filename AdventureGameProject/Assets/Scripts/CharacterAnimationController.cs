using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        HandleAnimations();
    }
    
    private void HandleAnimations()
    {
        //run
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("RunTrigger");
        }
        else
        {
            animator.SetTrigger("IdleTrigger");
        }
        
        //jump
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.SetTrigger("IdleTrigger");
        }

        //Fall
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("IdleTrigger");
        }
    }
}
