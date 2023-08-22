using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_3_exp : MonoBehaviour
{
    public bool destroyedEnemy3 = false;
    void ExplosionDone()
    {
        Destroy(gameObject);
        GameObject.Find("VictoryPanel").SetActive(true);
        destroyedEnemy3 = true;
    }
}
