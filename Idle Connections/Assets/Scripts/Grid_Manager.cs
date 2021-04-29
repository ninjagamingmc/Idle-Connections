using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid_Manager : MonoBehaviour
{
    public int gridSize = 9;
    public GameObject[] playerGridArray;
    public GameObject playerGrid;
    public GameObject test;
    public bool[] filledArray;
    public bool filled;

    // Start is called before the first frame update
    void Start()
    {
        playerGridArray = new GameObject[gridSize];
        playerGridArray[0] = test;

        filledArray = new bool[gridSize];

        for (int i = 0; i < gridSize; i++) {
            filledArray[i] = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < gridSize; i++) {
            if (filledArray[i] == false)
            {
                if (playerGridArray[i] != null) {
                    Instantiate(playerGridArray[i], new Vector2(0, 0), Quaternion.identity);
                    filledArray[i] = true;
                }  
            }
        }
    }
}
