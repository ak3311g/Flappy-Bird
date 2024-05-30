using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float power = 3f;
    public Manager manager;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Manager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(alive&&Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * power;
        }    

        if(transform.position.y > 5f||transform.position.y < -5f)
        {
            manager.GameOver();
            alive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        manager.GameOver();
        alive = false;
    }
}
