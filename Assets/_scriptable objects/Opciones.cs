using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : ScriptableObject
{
    dificultadSeleccionada BloqueResistencia;
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil; 

    //public enum dificultad
    //{
    //    facil,
    //    normal,
    //    dificil
    //}

    //public dificultad dificultadElegida;
    //internal dificultad facil;
    //internal dificultad normal;
    //internal dificultad dificil;

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }



    public void CambiarDificultad(int nuevaDificultad)
    {
        //if (dificultadElegida == dificultad.facil)
        //{
        //BloqueResistencia = resistencia = +0;
        //}
        //else if (dificultadElegida == dificultad.normal)
        //{
        //    //BloqueResistencia = resistencia = +1;               //en script bloque
        //}
        //else if (dificultadElegida == dificultad.dificil)
        //{
        //    //BloqueResistencia = resistencia = +2;
        //}
        NivelDificultad = (dificultad)nuevaDificultad;
    }

    public void iniciarjuego()
    {

    } 
}
public enum dificultad
{
    facil,
    normal,
    dificil
}
