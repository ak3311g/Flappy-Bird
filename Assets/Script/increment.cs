using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increment : MonoBehaviour
{
    // Start is called before the first frame update

    public Manager manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3){
        manager.AddScore();}
    }
}
