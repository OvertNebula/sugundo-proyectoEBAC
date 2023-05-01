using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField] public float velocidadBola = 10.0f;
    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();
        isGameStarted = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("jugador").transform);
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (control.salidaAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if (control.salidaArriba)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde superior");
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadBola * direccion;
            control.salidaArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }
        if (control.salidaDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde Derecho");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadBola * direccion;
            control.salidaDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }
        if (control.salidaIzquierda)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde Izquierda");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = velocidadBola * direccion;
            control.salidaIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
    }

    public void HabilitarControl()
    {
        control.enabled = true;
    }
    public void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }

    public void LateUpdate()
    {
        if (direccion != Vector3.zero) direccion = Vector3.zero;

    }
}
