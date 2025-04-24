using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthData;
    public GameObject player;

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }

    public void NoHealth(float amount)
    {
        if (healthData.value <= 0)
        {
            Destroy(player);
            StartCoroutine(WaitForSceneLoad());
        }
    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenue");
    }
}
