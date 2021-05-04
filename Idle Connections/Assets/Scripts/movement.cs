using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;

    private Rigidbody2D rb;
    Vector3 randVel;

    private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        var z = 0;
        return new Vector3(x, y, z);
    }
    // Start is called before the first frame update
    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("grow");

        rb = GetComponent<Rigidbody2D>();
       
        randVel = RandomVector(-10f, 10f);
        randVel = Vector3.Normalize(randVel) * 5;
        //rb.AddForce(randVel);
        //childrenRb.AddForce(randVel);//doesnt do multiple random seeds??? for some reason???? i dont get it. maybe there's just 1 obj
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(randVel * Time.deltaTime);
        //if dead
        //anim.Play("shrink");
    }
}
