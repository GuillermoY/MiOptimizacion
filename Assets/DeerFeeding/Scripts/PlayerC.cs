using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    float speed = 15f;
    float horzinput;
    float verinput;
    float limitx = 14;
    float limitz = 5;
    public GameObject Proyectilpref;
    public float vidas = 6;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -limitx)
        {
            transform.position = new Vector3(-limitx, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < -limitz)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limitz);
        }
        if (transform.position.x > limitx)
        {
            transform.position = new Vector3(limitx, transform.position.y, transform.position.z);
        }
        else if (transform.position.z > limitz)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limitz);
        }
        horzinput = Input.GetAxis("Horizontal");
        verinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * horzinput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verinput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Proyectilpref, new Vector3(transform.position.x, transform.position.y, transform.position.z + 2), Proyectilpref.transform.rotation);
        }
    }
    void OnTriggerEnter(Collider PlayerColl)
    {
        switch (vidas)
        {
            case 6:
                Debug.Log("Vidas : 5");
                vidas = vidas - 1;
                break;
            case 5:
                Debug.Log("Vidas : 4");
                vidas = vidas - 1;
                break;
            case 4:
                Debug.Log("Vidas : 3");
                vidas = vidas - 1;
                break;
            case 3:
                Debug.Log("Vidas : 2");
                vidas = vidas - 1;
                break;
            case 2:
                Debug.Log("Vidas : 1");
                vidas = vidas - 1;
                break;
            case 1:
                Debug.Log("Vidas : 0");
                vidas = vidas - 1;
                break;
            case 0:
                Debug.Log("GAME OVER");
                Destroy(gameObject);
                break;
        }
    }
}
