using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosiciónCamara : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);//offset (compensar)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()//Lateupdate hace que se llame primero Update y luego LateUpdate lo que elimina la inestabilidad de la camara
    {
        //posiciona la camara destras del objeto (jugador) usando las cordenadas del mismo y añadiendo un vector3 para posicionarla adecuadamente
        transform.position = player.transform.position + offset;
    }
}
