using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2Prototype");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
