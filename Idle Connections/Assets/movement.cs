using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;

    private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        var z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("grow");

        var rb = GetComponent<Rigidbody2D>();
        var childrenRb = GetComponentInChildren<Rigidbody2D>();
        var randVel = RandomVector(20f, 30f);
        rb.AddForce(randVel);
        childrenRb.AddForce(randVel);//doesnt do multiple random seeds??? for some reason???? i dont get it. maybe there's just 1 obj
    }

    // Update is called once per frame
    void Update()
    {
        //if dead
        //anim.Play("shrink");
    }
}
