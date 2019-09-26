using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{
    // Start is called before the first frame update
    Light luz;

    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Color rojo = new Color(1f, 0f, 0f);
        Color azul = new Color(0f, 0f, 1f);
        Color blanco = new Color(1f, 1f, 1f);

        if (luz.intensity <= 0.25 && luz.intensity <= 0.5)
        {
            luz.color = azul;
        }
        else if (luz.intensity <= 0.5 && luz.intensity <= 0.75)
        {
            luz.color = rojo;
        }
        else if (luz.intensity <= 0.75)
        {
            luz.color = blanco;
        }

    }
}
