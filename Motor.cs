using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float magnitud = 8;
    [SerializeField] float magnitud2 = 90;
    [SerializeField] AudioClip idle;
    [SerializeField] AudioClip driving;


    AudioSource audiosource;
    Rigidbody rb;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        Vector3 direccionZ = transform.forward * Input.GetAxis("Vertical");

        Vector3 velocidad = magnitud * (direccionZ);
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;

        Vector3 DirAng = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magnitud2 * (DirAng);
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        if((direccionZ.z > 0) || (DirAng.y > 0) || (direccionZ.z < 0) || (DirAng.y < 0))
        {
            audiosource.clip = driving;
            if (audiosource.isPlaying == false) audiosource.Play();
        }
        else
        {
            audiosource.clip = idle;
            if (audiosource.isPlaying == false) audiosource.Play();
        }

        float magFuerza = 300;
        float sentido = 1;
        Vector3 dir = transform.forward;
        Vector3 fuerza = magFuerza * dir * sentido;

        float magFuerza2 = 300;
        float sentido2 = 1;
        Vector3 dir2 = new Vector3(0, 1, 0);
        Vector3 fuerza2 = magFuerza2 * dir2 * sentido2;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(fuerza);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(fuerza2);
        }
    }
}

