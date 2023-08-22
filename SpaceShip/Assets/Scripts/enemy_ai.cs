using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ai : MonoBehaviour
{
    public GameObject explosion;

    ///////////////////////Enemy movement///////////////////////
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 moveDirection;
    Transform target;
    ///////////////////////Enemy movement///////////////////////


    ///////////////////////Enemy damage///////////////////////
    public int health = 3;
    private int curHealth;
    public Animator animator;
    ///////////////////////Enemy damage///////////////////////

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        curHealth = health;
    }

    void Update()
    {
        target = GameObject.Find("Player").transform;
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = direction.x;
            rb.rotation = angle;
            moveDirection = direction;
        }

        ///////////////////////Enemy damage///////////////////////
        if (curHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            animator.SetInteger("destroy", curHealth);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
    }
    ///////////////////////Enemy movement///////////////////////


    ///////////////////////Enemy damage///////////////////////
    public void damageEnemy(int damage)
    {
        curHealth -= damage;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            curHealth -= curHealth;
        }
    }
    ///////////////////////Enemy damage///////////////////////
}
