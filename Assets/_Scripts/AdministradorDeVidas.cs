 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDeVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach(Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);
        }
        vidas.RemoveAt(0);
    }

    public void EliminarVida()
    {
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if (vidas.Count <= 0)
        {
            MenuFinJuego.SetActive(true);
            return;
        }
        var bola = Instantiate(bolaPrefab) as GameObject;
        bolaScript = bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(this.EliminarVida);
        Debug.Log($"Vidas Restantes: {vidas.Count}");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
