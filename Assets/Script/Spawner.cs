using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject walls;
    public float timer = 0;
    public float spawnTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer > spawnTime)
        {
            Spawn();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void Spawn()
    {
        float y = Random.Range(7f, 1.2f);
        Instantiate(walls, new Vector3(transform.position.x,y,transform.position.z), Quaternion.identity);
    }
}
