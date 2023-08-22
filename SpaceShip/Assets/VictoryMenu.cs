using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public bool destroyedBoss;

    public GameObject victoryMenu;
    public GameObject Enemy2;

    private float timer;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null && GameObject.FindWithTag("EnemyExplosion") == null && GameObject.FindWithTag("Enemy_2") == null)
        {
            timer += Time.deltaTime;
            if (timer > 4)
            {
                if (GameObject.FindWithTag("Enemy") == null && GameObject.FindWithTag("EnemyExplosion") == null && GameObject.FindWithTag("Enemy_2") == null)
                {
                    Time.timeScale = 0f;
                    victoryMenu.SetActive(true);
                    Cursor.visible = true;  
                }
            }
        }
    }

    public void btnExit()
    {
        Application.Quit();
    }

    public void btnRestart()
    {
        Time.timeScale = 1f;
        victoryMenu.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void btnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        victoryMenu.SetActive(false);
        Cursor.visible = false;
    }
}