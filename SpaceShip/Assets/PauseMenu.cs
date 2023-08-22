using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        
    }

    public void pouseButton()
    {
        if (!pauseMenu.activeSelf)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            Cursor.visible = false;
        }
    }

    public void btnExit()
    {
        Application.Quit();
    }

    public void btnRestart()
    {
        SceneManager.LoadScene("Level-1");
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }
}
