using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileControlls : MonoBehaviour
{
    public GameObject Player;

    public float speed;
    public float player;
    public float Move;
    public bool isShooting;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void btnLeft()
    {
        float Move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
    }

    public void btnRight()
    {

    }
}
