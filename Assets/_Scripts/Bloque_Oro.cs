using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Oro : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 10;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
