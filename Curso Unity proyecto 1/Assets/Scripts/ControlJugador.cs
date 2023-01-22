using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float speed = 5.0f;/*public vs private es la visibilidad externa a la clase, desde fuera en private no se podira acceder al valor pero como public si se puede.
    al ser publica se puede ver y manupular en unity*/
    public float turnSpeed = 25.0f;
    public float inputAvanzar;
    public float inputGirar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento del vehiculo

        inputGirar = Input.GetAxis("Horizontal");//(Horizontal es el nombre por defecto) Unity tiene los valores en edit-> proyect settings -> input manager
        inputAvanzar = Input.GetAxis("Vertical");


        //transform (no Transform) es el parametro del objeto usado para moverlo en los ejes
        //Unity: el mesh collider maneja las colisionces (pero son inamobibles) con un rigid body podes hacer que un objeto choque con otro y ambos se muevan con la fuerza del impacto
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputAvanzar);
        //el siguente if hace que acelere de forma acumulativa hasta 30 mps(metros por segundo)
        if(inputAvanzar != 0)
        {
            if(speed<30)
            {
            speed = speed + 0.2f;
            }
            
        }
        else
        {
            speed = 5f;
        }
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * inputGirar);
        
    }
}
