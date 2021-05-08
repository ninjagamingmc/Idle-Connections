using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Green : MonoBehaviour
{
    GameObject myGrid;
    Grid_Manager gridManager;
    public GameObject greenBlock;

    GameObject scoreDisplay;
    ScoreController scoreController;

    void Start()
    {
        myGrid = GameObject.FindGameObjectWithTag("Grid");
        gridManager = myGrid.GetComponent<Grid_Manager>();

        scoreDisplay = GameObject.FindGameObjectWithTag("Score");
        scoreController = scoreDisplay.GetComponent<ScoreController>();
    }


    // Update is called once per frame
    public void AddGreen()
    {
        for (int i = 0; i < 9; i++)
        {
            if (gridManager.playerGridArray[i] == null)
            {
                if (removePoints()) {
                    gridManager.playerGridArray[i] = greenBlock;
                    break;
                }
            }
        }
    }

    //remove score
    public bool removePoints()
    {
        if (scoreController.score >= 50)
        {
            scoreController.score -= 50;
            return true;
        }
        else
        {
            return false;
        }
    }
}
