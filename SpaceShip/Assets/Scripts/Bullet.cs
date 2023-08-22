using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2 (1, 0);
    public float speed = 2;
    public Vector2 velocity;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed;
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.deltaTime;
        transform.position = pos;
    }
}
