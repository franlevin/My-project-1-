using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    public float activeCamera = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("asasaasasa");
            switch(activeCamera)
            {
                case 0: 
                    cameras[1].SetActive(true);
                    cameras[0].SetActive(false);
                    activeCamera = 1;
                    break;
                case 1: 
                    cameras[0].SetActive(true);
                    cameras[1].SetActive(false);
                    activeCamera = 0;
                    break;
            } 
        } 
    }
}