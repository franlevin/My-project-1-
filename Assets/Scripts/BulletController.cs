using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletDamage = 10f;
    public float bulletSpeed = 4f;
    public Vector3 bulletDirection = new Vector3(0f, 0f, 1f);
    public float lifeTime = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += bulletDirection * bulletSpeed * Time.deltaTime;
        transform.Translate(bulletDirection * bulletSpeed * Time.deltaTime);
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += transform.localScale;
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
