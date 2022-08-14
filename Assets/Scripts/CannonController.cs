using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour


{
    public GameObject Bullet;
    public float spawnDelay = 0.5f;
    public float intervalDelay = 0.5f;


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
        Instantiate(Bullet, transform.position, Bullet.transform.rotation);
    }
}
