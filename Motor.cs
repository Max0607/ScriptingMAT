using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float magnitud = 8;
    [SerializeField] float magnitud2 = 90;
    [SerializeField] float cooldown = 8, force = 500;
    [SerializeField] AudioClip idle;
    [SerializeField] AudioClip driving;
    [SerializeField] float Salud = 100;
    [SerializeField] float daño = 10;



    AudioSource audiosource;
    Rigidbody rb;
    float t = 0;
    bool dash = false;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        t = cooldown;
    }


    // Update is called once per frame
    void Update()
    {
        rb.WakeUp();
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
    }

    private void OnCollisionStay(Collision piso)
    {
        dash = true;
        GameObject colision = piso.gameObject;
        Rigidbody colisionCuerpo = colision.GetComponent<Rigidbody>();

        if (Input.GetButtonDown("Jump") && dash == true)
        {
            Vector3 dire = transform.up * 0.3f;
            rb.AddForce(dire * force);
        }

    }

    public void Destruir()
    {

        if(tag == "Jugador")
        {
            Salud -= daño;
            if (Salud <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

