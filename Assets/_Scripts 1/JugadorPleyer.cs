using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorPleyer : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float velocidadPaddle = 5f; //velocidad de movimiento 

    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "bola")
        {
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        }
       

    }
    // Update is called once per frame
    void Update()
    {
        mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;


        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    //mueve el objeto derecha
        //    transform.Translate(Vector3.down * velocidadPaddle * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{t
        //    ransform.Translate(Vector3.up * velocidadPaddle * Time.deltaTime);
        //    //mueve el objeto a la izquierda
        //}

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPaddle * Time.deltaTime);

        //Vector3 pos = transform.position;
        //pos.x = mousePos3D.x;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if(pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        this.transform.position = pos;
    }
}
