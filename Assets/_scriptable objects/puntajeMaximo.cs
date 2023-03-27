using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "puntajeMaximo", menuName = "Herramientas/puntajeMaximo", order =0)]
public class puntajeMaximo : PuntajePersistente 
{
    public int puntaje = 0;
    public int PuntajeMaximo = 10000;
}
