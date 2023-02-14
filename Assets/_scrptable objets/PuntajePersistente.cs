using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PuntajePersistente : MonoBehaviour
{
    public void Guardar(string NombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(NombreArchivo);
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public virtual void Cargar(string nombreArchivo = null)
    {
        if (File.Exists(ObtenerRuta(nombreArchivo)))
        {
            var bf = new BinaryFormatter();
            var archivo = File.Open(ObtenerRuta(nombreArchivo), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);
            archivo.Close();
        }
    }

    public string ObtenerRuta(string nombreArchivo = null)
    {
        var nombreArchovoCompleto = string.IsNullOrEmpty(nombreArchivo) ? name : nombreArchivo;
        return string.Format("(0)/(1).ebac PT", Application.persistentDataPath, nombreArchovoCompleto);
    }
}
