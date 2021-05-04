using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Manager : MonoBehaviour
{
    public int gridSize = 9;
    public GameObject[] playerGridArray;
    public GameObject playerGrid;
    public bool[] filledArray;
    public bool filled;

    // Start is called before the first frame update
    void Start()
    {
        playerGridArray = new GameObject[gridSize];
        

        filledArray = new bool[gridSize];

        for (int i = 0; i < gridSize; i++) {
            filledArray[i] = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //square 1
        if (filledArray[0] == false) {
            Instantiate(playerGridArray[0], new Vector2(-1.5f, 1.5f), Quaternion.identity);
            filledArray[0] = true;
        }

        //square 2
        if (filledArray[1] == false)
        {
            Instantiate(playerGridArray[1], new Vector2(-0f, 1.5f), Quaternion.identity);
            filledArray[1] = true;
        }

        //square 3
        if (filledArray[2] == false)
        {
            Instantiate(playerGridArray[2], new Vector2(1.5f, 1.5f), Quaternion.identity);
            filledArray[2] = true;
        }

        //square 4
        if (filledArray[3] == false)
        {
            Instantiate(playerGridArray[3], new Vector2(-1.5f, 0f), Quaternion.identity);
            filledArray[3] = true;
        }

        //square 5
        if (filledArray[4] == false)
        {
            Instantiate(playerGridArray[4], new Vector2(0f, 0f), Quaternion.identity);
            filledArray[4] = true;
        }

        //square 6
        if (filledArray[5] == false)
        {
            Instantiate(playerGridArray[5], new Vector2(1.5f, 0f), Quaternion.identity);
            filledArray[5] = true;
        }

        //square 7
        if (filledArray[6] == false)
        {
            Instantiate(playerGridArray[6], new Vector2(-1.5f, -1.5f), Quaternion.identity);
            filledArray[6] = true;
        }

        //square 8
        if (filledArray[7] == false)
        {
            Instantiate(playerGridArray[7], new Vector2(0f, -1.5f), Quaternion.identity);
            filledArray[7] = true;
        }

        //square 9
        if (filledArray[8] == false)
        {
            Instantiate(playerGridArray[8], new Vector2(1.5f, -1.5f), Quaternion.identity);
            filledArray[8] = true;
        }
    }
}
