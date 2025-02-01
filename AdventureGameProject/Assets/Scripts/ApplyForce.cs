using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 260);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
