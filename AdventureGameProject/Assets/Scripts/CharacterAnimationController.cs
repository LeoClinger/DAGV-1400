using System.Collections;
using System.Collections.Generic;
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
        //double jump
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("DoubleJump");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        
        //Hit
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        //Fall
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }
}
