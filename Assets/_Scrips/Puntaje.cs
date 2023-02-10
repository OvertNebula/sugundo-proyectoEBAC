using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class puntaje : MonoBehaviour
{
    public Transform transformPuntajeMaximo;
    public Transform transformPuntaje;
    public TMP_Text textoPuntajeMaximo;
    public TMP_Text textoPuntaje;
    public puntajeMaximo puntajeMaximoSO;
    
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
        textoPuntajeMaximo.text = $"puntajeMaximo: {puntajeMaximoSO.PuntajeMaximo}";
        puntajeMaximoSO.Puntaje = 0;
    }

    private void FixedUpdate()
    {
        puntajeMaximoSO.Puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = $"Puntaje: {puntajeMaximoSO.Puntaje}";
        if(puntajeMaximoSO.Puntaje > puntajeMaximoSO.PuntajeMaximo)
        {
            puntajeMaximoSO.PuntajeMaximo = puntajeMaximoSO.Puntaje;
            textoPuntajeMaximo.text = $"PuntajeMaximo: {puntajeMaximoSO.PuntajeMaximo}";
            //PlayerPrefs.SetInt("puntajeMaximo", puntos);
        }
    }
}
