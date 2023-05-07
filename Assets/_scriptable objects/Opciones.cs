using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : ScriptableObject
{
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;

    public enum dificultad
    {
        facil,
        normal,
        dificil
    }

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }

    public void CambiarDificultad(int nuevaDificultad)
    {
        velocidadBola = (float)velocidadBola / nuevaDificultad;
        NivelDificultad = (dificultad)nuevaDificultad;
    }

    public void iniciarjuego()
    {

    }
}
