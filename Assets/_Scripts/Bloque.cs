using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dificultadSeleccionada : MonoBehaviour
{
    Opciones dificultad;
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

    public dificultadSeleccionada()
    {
        int recistenciaActualizada = RecistenciaActual();
    }

    public void cambiosALaDificultad()
    {
        dificultadACambiar = GameObject.FindGameObjectWithTag("Tag3").GetComponent<Opciones>();
        
        //dificultadACambiar.dificultadElegida(gameObject);
        if (dificultadACambiar.dificultadElegida == dificultad.facil)
        {
            resistencia = +0;
        }
        else if (dificultadACambiar.dificultadElegida == dificultad.normal)
        {
            resistencia = +1;               
        }
        else if (dificultadACambiar.dificultadElegida == dificultad.dificil)
        {
            resistencia = +2;
        }
        
        

    }
    public int RecistenciaActual()
    {
        int RecisteciaAplicada = resistencia;
        return RecisteciaAplicada;
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;

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
