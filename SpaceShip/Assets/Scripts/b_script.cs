using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_script : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_Timer = 3f;

    public int bulletDamage = 1;

    void Start()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("DestroyGameObject", deactivate_Timer);
        }
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy_3")
        {
            other.gameObject.GetComponent<Enemy_3>().damageEnemy(bulletDamage);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Enemy_2")
        {
            other.gameObject.GetComponent<EnemyShooting>().damageEnemy(bulletDamage);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<enemy_ai>().damageEnemy(bulletDamage);
            Destroy(gameObject);
        }
    }
}
