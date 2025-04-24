using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ButtonToLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void ButtonQuits()
    {
        Application.Quit();
    }
}
