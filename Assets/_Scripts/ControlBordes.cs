using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBordes : MonoBehaviour
{
    [Header("Configurar en el editor")]
    public float radio = 1f;
    public bool mantenerPantalla = false;

    [Header("Configuraciones dinamicas")]
    public bool estaEnPantalla = true;
    public float anchoCamara;
    public float altoCamara;
    public bool salidaDerecha, salidaIzquierda, salidaArriba, salidaAbajo;

    public ControlBordes Control { get; private set; }

    private bool isGamestarted;

    public void Awake()
    {
        altoCamara = Camera.main.orthographicSize;
        anchoCamara = Camera.main.aspect * altoCamara;
        
    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        estaEnPantalla = true;
        salidaAbajo = salidaArriba = salidaDerecha = salidaIzquierda = false;
        if (pos.x > anchoCamara - radio)
        {
            pos.x = anchoCamara - radio;
            salidaDerecha = true;
        }
        if (pos.x < -anchoCamara + radio)
        {
            pos.x = -anchoCamara + radio;
            salidaIzquierda = true;
        }
        if (pos.y > altoCamara - radio)
        {
            pos.y = altoCamara - radio;
            salidaArriba = true;
        }
        if (pos.y < -altoCamara + radio)
        {
            pos.y = -altoCamara + radio;
            salidaAbajo = true;
        }

        estaEnPantalla = !(salidaAbajo || salidaArriba || salidaDerecha || salidaIzquierda);
        if (mantenerPantalla && !estaEnPantalla)
        {
            transform.position = pos;
            estaEnPantalla = true;
        }
    }
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 tamañoBorde = new Vector3(anchoCamara * 2, altoCamara * 2, 0.1f);
        Gizmos.DrawCube(Vector3.zero, tamañoBorde);
    }
}
