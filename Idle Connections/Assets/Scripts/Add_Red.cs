using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Red : MonoBehaviour
{
    GameObject myGrid;
    Grid_Manager gridManager;
    public GameObject redBlock;

    void Start()
    {
        myGrid = GameObject.FindGameObjectWithTag("Grid");
        gridManager = myGrid.GetComponent<Grid_Manager>();


    }


    // Update is called once per frame
    public void AddRed()
    {
        for (int i = 0; i < 9; i++)
        {
            if (gridManager.playerGridArray[i] == null)
            {
                gridManager.playerGridArray[i] = redBlock;
                break;
            }
        }
    }
}
