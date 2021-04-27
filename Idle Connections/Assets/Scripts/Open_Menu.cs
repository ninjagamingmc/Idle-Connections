using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Menu : MonoBehaviour
{
    public GameObject menu;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        if (Input.GetMouseButtonUp(1)) {
                Instantiate(menu, new Vector2(pos.x + 3, pos.y), Quaternion.identity);
        }
    }
}
