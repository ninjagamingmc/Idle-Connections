using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour
{
    private List<Collider2D> colliders = new List<Collider2D>();
    private List<LineRenderer> lines = new List<LineRenderer>();
    public List<Collider2D> GetColliders() { return colliders; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
        colliders.Add(other); //hashset automatically handles duplicates
        AutoAttach(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        colliders.Remove(other);
    }

    void AutoAttach(Collider2D node)
    {
        LineRenderer line = this.gameObject.AddComponent<LineRenderer>();

        lines.Add(line);
    }

    private void LateUpdate()
    {
        Debug.Log(colliders.Count);
        if (colliders.Count != 0)
        {
            for (int i = 0; i <= colliders.Count; i++)
            {
                // Set the number of vertex fo the Line Renderer
                lines[i].SetPosition(0, transform.position);
                lines[i].SetPosition(1, colliders[i].transform.position);
            }
        }
    }
}