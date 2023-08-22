using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ship_move : MonoBehaviour
{
    public GameObject explosion;
    public GameObject deathMenu;
    public Animator animator;

    [SerializeField]
    private GameObject p_bullet;

    [SerializeField]
    private Transform attack_p; 

    public float attack_t = 0.3f;
    private float current_a_t;
    private bool canAttack;

    public int health = 3;
    public int curPlayerHealth;

    public float speed;
    public float player;
    public float Move;
    public bool isShooting;
    public Rigidbody2D rb;

    void Start()
    {
        current_a_t = attack_t;
        curPlayerHealth = health;
    }

    void Update()
    {
        Move = SimpleInput.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        Attack();

        if (curPlayerHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            animator.SetInteger("destroy", curPlayerHealth);
        }
    }

    void Attack()
    {
        attack_t += Time.deltaTime;
        if(attack_t > current_a_t)
        {
            canAttack = true;
        }

        /*if (Input.GetKeyDown(KeyCode.K))
        {
            isShooting = true;
            if (canAttack)
            {
                canAttack = false;
                attack_t = 1f;
                Instantiate(p_bullet, attack_p.position, Quaternion.identity);
            }
        }*/
    }

    public void shoot()
    {
        isShooting = true;
        if (canAttack)
        {
            canAttack = false;
            attack_t = 1f;
            Instantiate(p_bullet, attack_p.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            curPlayerHealth = curPlayerHealth - 2;
        }
    }



    public void damagePlayer(int damage)
    {
        curPlayerHealth -= damage;
    }
}
