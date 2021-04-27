using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Controller : MonoBehaviour
{
    public GameObject blue;
    private GameObject blueChild;
    public GameObject green;
    private GameObject greenChild;
    public GameObject red;
    private GameObject redChild;

    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
        blueChild = Instantiate(blue, new Vector2(pos.x, pos.y + 2), Quaternion.identity);
        greenChild = Instantiate(green, new Vector2(pos.x, pos.y ), Quaternion.identity);
        redChild = Instantiate(red, new Vector2(pos.x, pos.y - 2), Quaternion.identity);

        blueChild.transform.SetParent(menu.transform);
        greenChild.transform.SetParent(menu.transform);
        redChild.transform.SetParent(menu.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
