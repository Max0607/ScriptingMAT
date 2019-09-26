using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer render;
    float t = 0;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color rojo = new Color(1f, 0f, 0f);
        Color azul = new Color(0f, 0f, 1f);
        Color morado = new Color(1f, 0f, 1f);

        t += Time.deltaTime;
        if (t <= 3)
        {
            render.material.color = rojo;
        }
        else if (t >= 3 && t<= 6)
        {
            render.material.color = azul;
        }
        else if (t >= 6)
        {
            render.material.color = morado;
        }
    }
}
