using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour


{
    public GameObject Bullet;
    public float spawnDelay = 1f;
    public float intervalDelay = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", spawnDelay, intervalDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(Bullet, transform);
    }
}
