using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class FlagAnimScript : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    //scene wait to load
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenue");
    
    }
    private void OnTriggerEnter(Collider other)
    {
        //flag up
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("HitFlag");
            animator.SetTrigger("Fly");
            StartCoroutine(WaitForSceneLoad());
        }
    }
}
