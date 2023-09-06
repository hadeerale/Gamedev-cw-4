using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss2 : MonoBehaviour
{
    rigidbody2D rb;
    AudioSorce srs;
    public float speed = 13.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        srs = GetComponent<Audiosorce>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = vector2.ClampManegitud(rb.velocity, speed); 
    }


    void OnCollisionEnter2D(Collision2D collision);
        src.play();
}
