using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    float t = 0;
    [SerializeField] float duracion = 5f;
    [SerializeField] float fuerza = 1200;

    Rigidbody rb;

    Motor motor;
    Construccion cons;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        motor = GetComponent<Motor>();
        cons = GetComponent<Construccion>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.WakeUp();
        t += Time.deltaTime;
        if (t >= duracion)
        {
            Destroy(gameObject);
        }
    }

    public void Disparar()
    {
        rb.AddForce(transform.forward * fuerza);
    }

    private void OnCollisionEnter(Collision tanque)
    {
        GameObject colision = tanque.gameObject;
        Rigidbody colisionCuerpo = colision.GetComponent<Rigidbody>();

        if(tanque.gameObject.CompareTag("Jugador"))
        {
            Motor other = (Motor)tanque.gameObject.GetComponent(typeof(Motor));
            other.Destruir();
        }

        if (tanque.gameObject.CompareTag("Construccion"))
        {
            Construccion other = (Construccion)cons.gameObject.GetComponent(typeof(Construccion));
        }
    }
}
