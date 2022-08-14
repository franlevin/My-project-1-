using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float health = 100f;
    public float speed = 4f;
    public float cameraAxisX;

    // Start is called before the first frame update
    void Start()
    {
        lowerPlayerHealth(10f);
        Debug.Log("La vida debería ser 90, la vida es: " + health);        
    }

    // Update is called once per frame
    void Update()
    {
        
        checkMovement();
    }

    void checkMovement()
    {
        rotatePlayer();

        if (Input.GetKey(KeyCode.W)) {
        movePlayer(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.A)) {
        movePlayer(Vector3.left);
        }

        if (Input.GetKey(KeyCode.S)) {
        movePlayer(Vector3.back);
        }

        if (Input.GetKey(KeyCode.D)) {
        movePlayer(Vector3.right);
        }
    }

    void movePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void lowerPlayerHealth (float loss)
    {
        health -= loss;
    }

    void raisePlayerHealth (float gain)
    {
        health += gain;   
    }

    public void rotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        //transform.rotation = Quaternion.Euler(0, cameraAxisX, 0);
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);
    }
}
