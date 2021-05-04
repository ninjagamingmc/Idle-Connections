using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Create : MonoBehaviour
{
    public GameObject blueBlock;
    public GameObject greenBlock;
    public GameObject redBlock;

    private Transform node;

    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
        int checkBlue = Random.Range(0, 100);
        int checkRed = Random.Range(0, 100);
        int checkGreen = Random.Range(0, 100);

        node = transform.parent;

        if (checkBlue >= 50) 
        {
            GameObject blue = Instantiate(blueBlock, new Vector2(pos.x - 3 / 2, pos.y), Quaternion.identity);
            blue.transform.SetParent(transform);
        }
        if(checkGreen >= 50) 
        {
            GameObject green = Instantiate(greenBlock, new Vector2(pos.x, pos.y + 3 / 2), Quaternion.identity);
            green.transform.SetParent(transform);
        } 
        if (checkRed >= 50)
        {
            GameObject red = Instantiate(redBlock, new Vector2(pos.x + 3 / 2, pos.y), Quaternion.identity);
            red.transform.SetParent(transform);
        }
    }
}
