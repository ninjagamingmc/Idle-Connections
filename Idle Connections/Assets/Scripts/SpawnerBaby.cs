using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBaby : MonoBehaviour
{
    public GameObject node;
    // Set your offset here (in seconds)
    float duration = 1;

    float timer = 1;

    void Update()
    {
        if (timer > 0)
        {
            // Reduces the timeout by the time passed since the last frame
            timer -= Time.deltaTime;

            // return to not execute any code after that
            return;
        }

        // this is reached when timeout gets <= 0
        float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
        Vector2 pos = new Vector2(spawnX, spawnY);
        // Spawn object once
        Instantiate(node, pos, Quaternion.identity);

        // Reset timer
        timer = duration;
    }
}
