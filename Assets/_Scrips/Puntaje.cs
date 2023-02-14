using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeMaximo;
    public Transform transformPuntaje;
    public TMP_Text textoPuntajeMaximo;
    public TMP_Text textoPuntaje;
    public PuntajeMaximo puntajeMaximoSO;
    
    // Start is called before the first frame update
    void Start()
    {
        transformPuntaje = GameObject.Find("Puntaje").transform;
        transformPuntajeMaximo = GameObject.Find("PuntajeMaximo").transform;
        textoPuntaje = transformPuntaje.GetComponent<TMP_Text>();
        textoPuntajeMaximo = transformPuntajeMaximo.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntajeMaximo"))
        //{
        //puntajeMaximo = PlayerPrefs.GetInt("puntajeMaximo");
        //}
        puntajeMaximoSO.Cargar();
        textoPuntajeMaximo.text = $"puntajeMaximo: {puntajeMaximoSO.puntajeMaximo}";
        puntajeMaximoSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        puntajeMaximoSO.puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = $"Puntaje: {puntajeMaximoSO.puntaje}";
        if(puntajeMaximoSO.puntaje > puntajeMaximoSO.puntajeMaximo)
        {
            puntajeMaximoSO.puntajeMaximo = puntajeMaximoSO.puntaje;
            textoPuntajeMaximo.text = $"PuntajeMaximo: {puntajeMaximoSO.puntajeMaximo}";
            puntajeMaximoSO.Guardar();
            //PlayerPrefs.SetInt("puntajeMaximo", puntos);
        }
    }
}
