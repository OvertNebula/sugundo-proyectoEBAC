using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    Opciones dificultadACambiar;
    public int resistencia = 1;
    public UnityEvent AumentarPuntage;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bola")
        {
            RebotarBola(collision);
        }

    }

    public void cambiosALaDificultad()
    {
        dificultadACambiar = GameObject.FindGameObjectWithTag("Tag3").GetComponent<Opciones>();

        //dificultadACambiar.dificultadElegida(gameObject);
        //if (dificultadElegida == dificultad.facil)
        //{
        //    //BloqueResistencia = resistencia = +0;
        //}
        //else if (dificultadElegida == dificultad.normal)
        //{
        //    //BloqueResistencia = resistencia = +1;               
        //}
        //else if (dificultadElegida == dificultad.dificil)
        //{
        //    //BloqueResistencia = resistencia = +2;
        //}
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <=0)
        {
            AumentarPuntage.Invoke();
            Destroy(this.gameObject);
        }
    }
    public virtual void RebotarBola()
    {
         
    }
}
