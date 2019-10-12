using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public void ResetPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitPressed()
    {
        Application.Quit();
    }
}
