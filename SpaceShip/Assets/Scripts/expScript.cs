using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Rigidbody2D rb;
    Vector2 moveDirection;
    Transform target;

    //////////////////////////////////////////////////////////


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void ExplosionDone()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = direction.x;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }
}
