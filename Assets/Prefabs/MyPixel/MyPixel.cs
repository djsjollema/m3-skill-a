using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPixel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color color = Color.red;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        spriteRenderer.color = color;   
    }


}
