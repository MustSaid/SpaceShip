using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_scroll : MonoBehaviour
{
    [Range(-1f,1f)]
    public float speed = 0.5f;
    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }   

    void Update()
    {
        offset += (Time.deltaTime * speed) / 2f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
