using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMOVMENT : MonoBehaviour
{

    public float range = 2f; // Distance to move left and right from starting position
    public float speed = 2f; // Speed of movement

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPosition + new Vector3(newPosition, 0f, 0f);
    }
}
