using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    bool state = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
    }


    void Update()
    {

        if (state)
        {
            spriteRenderer.color = Color.green;
        } else
        {
            spriteRenderer.color = Color.red;
        }
        
    }

    private void OnMouseUp()
    {
        state = !state;
    }
}
