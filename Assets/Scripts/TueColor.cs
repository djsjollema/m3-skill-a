using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TueColor : MonoBehaviour
{
    [SerializeField] MyPixel myPixel;

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            float xRand = Random.Range(-4f, 4f);
            float yRand = Random.Range(-4f, 4f);

            Vector3 pos = new Vector3(xRand, yRand, 0);

            MyPixel copyOfPixel = Instantiate(myPixel, pos, Quaternion.identity);
            copyOfPixel.color = setRandomColor();
        }

    }

    void Update()
    {
        
    }

    Color setRandomColor()
    {
        float R = Random.value;
        float G = Random.value;
        float B = Random.value;

        Color newColor = new Color(R, G, B);
        return newColor;
    }
}
