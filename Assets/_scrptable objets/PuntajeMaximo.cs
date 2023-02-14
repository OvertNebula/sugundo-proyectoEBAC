using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PuntajeMaximo", menuName = "Tools/PuntajeMaximo", order =0)]
public class PuntajeMaximo : PuntajePersistente
{
    public int puntaje = 0;
    public int puntajeMaximo = 10000;
}
