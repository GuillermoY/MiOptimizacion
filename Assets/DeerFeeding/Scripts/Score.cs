using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;  
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ScoreMas()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
