using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowP : MonoBehaviour
{
    public GameObject Player;
    [SerializeField ]Vector3 uni�n = new Vector3(1,2,3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + uni�n;
    }
}
