using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet_2 : MonoBehaviour
{
    private GameObject player;
    public GameObject hit;
    public Transform hitPos;
    private Rigidbody2D rb;
    public int EnBulDamage = 1;
    public float bulletSpeed;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y) * bulletSpeed;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<ship_move>().curPlayerHealth -= EnBulDamage;
            Instantiate(hit, hitPos.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
