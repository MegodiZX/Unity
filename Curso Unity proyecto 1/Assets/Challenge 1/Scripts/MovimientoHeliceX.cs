using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHeliceX : MonoBehaviour
{
    public GameObject helice;
    public float velocidadHelice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadHelice);
    }
}
