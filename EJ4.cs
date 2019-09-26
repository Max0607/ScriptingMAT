using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    // Start is called before the first frame update
    Light luz;
    Transform mtransform;

    void Start()
    {
        luz = GetComponent<Light>();
        mtransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mtransform.localScale.magnitude > 1)
        {
            luz.intensity = mtransform.localScale.magnitude * 0.5f;
        }
      
    }
}
