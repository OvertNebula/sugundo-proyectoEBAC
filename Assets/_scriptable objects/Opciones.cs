using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : ScriptableObject
{
    Bloque BloqueResistencia;
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;

    public enum dificultad
    {
        facil,
        normal,
        dificil
    }
    public dificultad dificultadElegida;
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }

    public void CambiarDificultad(int nuevaDificultad)
    {
        if (dificultadElegida == dificultad.facil)
        {
            //BloqueResistencia = resistencia = +0;
        }
        else if (dificultadElegida == dificultad.normal)
        {
            //BloqueResistencia = resistencia = +1;
        }
        else if (dificultadElegida == dificultad.dificil)
        {
            //BloqueResistencia = resistencia = +2;
        }
        NivelDificultad = (dificultad)nuevaDificultad;
    }

    public void iniciarjuego()
    {

    }
}
