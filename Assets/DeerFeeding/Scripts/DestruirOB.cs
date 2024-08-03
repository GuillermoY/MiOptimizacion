using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirOB : MonoBehaviour
{
    float Topdistancia = 30;
    float Leftdistancia = 20;
    float Downdistancia = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Si un objetos se pasa de la vista del jugador, se borra
        if (transform.position.z > Topdistancia)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < Downdistancia)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > Leftdistancia)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -Topdistancia)
        {
            Destroy(gameObject);
        }

    }
}
