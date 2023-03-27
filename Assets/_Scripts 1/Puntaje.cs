using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    //public Transform transformPuntajeMaximo;
    //public Transform transformPuntaje;
    public TMP_Text textoPuntajeMaximo;
    public TMP_Text textoPuntaje;
    public puntajeMaximo puntajeMaximoSO;
    
    // Start is called before the first frame update
    void Start()
    {
        //transformPuntaje = GameObject.Find("Puntaje").transform;
        //transformPuntajeMaximo = GameObject.Find("PuntajeMaximo").transform;
        textoPuntaje = GameObject.Find("puntaje").GetComponent<TextMeshProUGUI>();//textoPuntaje = transformPuntaje.GetComponent<TMP_Text>();
        textoPuntajeMaximo = GameObject.Find("puntajeMaximo").GetComponent<TextMeshProUGUI>();//textoPuntajeMaximo = transformPuntajeMaximo.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("PuntajeMaximo"))
        //{
        //puntajeMaximo = PlayerPrefs.GetInt("puntajeMaximo");
        //}

        puntajeMaximoSO.Cargar();
        textoPuntajeMaximo.text = $"puntajeMaximo: {puntajeMaximoSO.PuntajeMaximo}";
        puntajeMaximoSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        puntajeMaximoSO.puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = $"puntaje: {puntajeMaximoSO.puntaje}";
        if(puntajeMaximoSO.puntaje > puntajeMaximoSO.PuntajeMaximo)
        {
            puntajeMaximoSO.PuntajeMaximo = puntajeMaximoSO.puntaje;
            textoPuntajeMaximo.text = $"puntajeMaximo: {puntajeMaximoSO.PuntajeMaximo}";
            puntajeMaximoSO.Guardar();
            //PlayerPrefs.SetInt("puntajeMaximo", puntos);
        }
    }
}
