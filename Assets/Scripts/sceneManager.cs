using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectChar()
    {
        SceneManager.LoadScene(3);
    }

    public void goHome_youWeak()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
