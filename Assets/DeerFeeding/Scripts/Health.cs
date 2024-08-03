using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image imahen;
    public float health = 100;
    public Score script;
    public int score;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;      
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MenosHealth(float damage)
    {
        health -= damage;
        imahen.fillAmount = health/100;
        if (health <= 0)
        {
            script.ScoreMas();
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        MenosHealth(damage);
    }


}
