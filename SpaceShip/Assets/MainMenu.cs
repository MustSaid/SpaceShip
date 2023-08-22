using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

    public void Start()
    {
        Time.timeScale = 0f;
        mainMenu.SetActive(true);
        Cursor.visible = true;
    }

    public void btnLevel1()
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene("Level-1");
    }

    public void btnLevel2()
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene("Level-2");
    }

    public void btnLevel3()
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene("Level-3");
    }

    public void btnExit()
    {
        Application.Quit();
    }
}
