using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour
{
    private List<Collider> colliders = new List<Collider>();
    private List<LineRenderer> lines = new List<LineRenderer>();
    public List<Collider> GetColliders() { return colliders; }

    private void OnTriggerEnter(Collider other)
    {
        colliders.Add(other); //hashset automatically handles duplicates
        AutoAttach(other);
    }

    private void OnTriggerExit(Collider other)
    {
        colliders.Remove(other);
    }

    void AutoAttach(Collider node)
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