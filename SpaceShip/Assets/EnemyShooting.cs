using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject victoryMenu;

    public GameObject explosion;

    public GameObject bullet;
    public Transform bulletPos;
    public bool destroyedBoss;

    private float timer;

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
        destroyedBoss = false;
    }

    void Update()
    {
        target = GameObject.Find("Player").transform;
        timer += Time.deltaTime;
        

        if (target != null)
        {
            if (timer > 2)
            {
                timer = 0;
                shoot();
            }

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

            timer += Time.deltaTime;
            if (timer >= 1)
            {
                Time.timeScale = 0f;
                victoryMenu.SetActive(true);
                Cursor.visible = true;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

    public void damageEnemy(int damage)
    {
        curHealth -= damage;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            curHealth = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyLimit"))
        {
            Destroy(GameObject.Find("EnemySpawn"));
            Destroy(GameObject.Find("EnemySpawn1"));
            Destroy(GameObject.Find("EnemySpawn2"));
        }
    }
}
