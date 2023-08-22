using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerExplosion : MonoBehaviour
{
    public GameObject deathMenu;

    void ExplosionDone()
    {
        Destroy(gameObject);
        /*SceneManager.LoadScene("SampleScene");*/
    }
}
