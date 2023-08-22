using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathMenu;

    private float timer;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (GameObject.Find("Player") == null)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                Time.timeScale = 0f;
                deathMenu.SetActive(true);
                Cursor.visible = true;
            }
        }
        /*else
        {
            Time.timeScale = 1f;
            deathMenu.SetActive(false);
            Cursor.visible = false;
        }*/
    }

    public void btnExit()
    {
        Application.Quit();
    }

    public void btnRestart()
    {
        Time.timeScale = 1f;
        deathMenu.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void btnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
