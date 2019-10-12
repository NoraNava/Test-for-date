using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartExitButtons : MonoBehaviour
{
    public void PressedStart()
    {
        SceneManager.LoadScene("Info");
    }

    public void PressedExit()
    {
        Application.Quit();
    }

    public void PressedReset()
    {
        SceneManager.LoadScene("GameScene");
    }
}
