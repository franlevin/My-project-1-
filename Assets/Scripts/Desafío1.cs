using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{   
    public Vector3 speed = new Vector3(0f, 0f, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = transform.localScale * 6;
        Debug.Log("Ejecutando Start()");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime;
    }
}
