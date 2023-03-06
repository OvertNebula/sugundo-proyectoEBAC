using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDePercistencia : MonoBehaviour
{
    public List<PuntajePersistente> ObjetosAguardar;
    public void OnEnable()
    {
        for (int i = 0; i < ObjetosAguardar.Count; i++)
        {
            var so = ObjetosAguardar[i];
            so.Cargar();
        }
    }
    public void OnDisable()
    {
        for (int i = 0; i < ObjetosAguardar.Count; i++)
        {
            var so = ObjetosAguardar[i];
            so.Guardar();
        }
    }
}
