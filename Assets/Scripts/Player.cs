using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float axisX;
    public float jumped;
    private Rigidbody2D rb;
    public bool jump=false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(axisX * speed, rb.velocity.y);

        if(Input.GetKeyDown("w") && jump==false)
        {
            rb.AddForce(new Vector2(0, jumped), ForceMode2D.Impulse);

            jump = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Floor"))
        {
            jump = false;
        }
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("ENEMIGO A LA VISTA");
        }
    }
}
