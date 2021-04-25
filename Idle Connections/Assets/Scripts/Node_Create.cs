using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Create : MonoBehaviour
{
    public GameObject blueBlock;
    public GameObject greenBlock;
    public GameObject redBlock;

    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
        int checkBlue = Random.Range(0, 100);
        int checkRed = Random.Range(0, 100);
        int checkGreen = Random.Range(0, 100);

        

        if (checkBlue >= 50) {
            Instantiate(blueBlock, new Vector2(pos.x - 3 / 2, pos.y), Quaternion.identity);
        }
        if(checkGreen >= 50) {
            Instantiate(greenBlock, new Vector2(pos.x, pos.y + 3 / 2), Quaternion.identity);
        }
        if (checkRed >= 50)
        {
            Instantiate(redBlock, new Vector2(pos.x + 3 / 2, pos.y), Quaternion.identity);
        }
    }
}
