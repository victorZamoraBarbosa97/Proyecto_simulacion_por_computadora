using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void changeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
