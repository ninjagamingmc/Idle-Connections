using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScore : MonoBehaviour
{
    GameObject scoreDisplay;
    ScoreController scoreController;


    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay = GameObject.FindGameObjectWithTag("Score");
        scoreController = scoreDisplay.GetComponent<ScoreController>();
        
    }

    // Update is called once per frame
    public void removePoints()
    {
        if (scoreController.score >= 50) {
            scoreController.score -= 50;
        }
    }
}
