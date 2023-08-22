using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public float speed;
    public float player;
    public float maxX, minX;
    public Rigidbody2D rb;

    private bool movingLeft = false;
    private bool movingRight = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float touchXPos = touch.position.x;

            if (touch.phase == TouchPhase.Began)
            {
                if (touchXPos < Screen.width / 2)
                {
                    movingLeft = true;
                }
                else
                {
                    movingRight = true;
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                movingLeft = false;
                movingRight = false;
            }
        }

        float horizontalMove = 0f;

        if (movingLeft)
        {
            horizontalMove = -1f;
        }
        else if (movingRight)
        {
            horizontalMove = 1f;
        }

        rb.velocity = new Vector2(speed * horizontalMove, rb.velocity.y);
    }
}
