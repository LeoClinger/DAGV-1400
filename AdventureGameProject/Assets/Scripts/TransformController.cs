using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
  private void Update()
  {
    //Move GameObject
    var x = Mathf.PingPong(Time.time, 1);
    var p = new Vector3(x, 0, 0);
    transform.position = p;
    
    //Rotate GameObject
    transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
  }
}
