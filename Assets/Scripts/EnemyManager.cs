using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)] 
    private float speed = 2;

    
    enum EnemyTypes { Cyborg, FemSkater, MaleSkater };
    [SerializeField] EnemyTypes enemyType;
    enum CyborgMovements { FemSkater, MaleSkater };
    [SerializeField] CyborgMovements cyborgMovement;
    [SerializeField] Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyType)
        {
            case EnemyTypes.Cyborg:
                // RotateAroundPlayer();
                if (cyborgMovement == CyborgMovements.FemSkater){
                    ChasePlayer();
                } else {
                    LerpStareAtPlayer();
                }
            break;

            case EnemyTypes.FemSkater:
                Debug.Log("Entró a femskater");
                ChasePlayer();
            break;

            case EnemyTypes.MaleSkater:
                LerpStareAtPlayer();
            break;
        }
    }

    void ChasePlayer()
    {
        StareAtPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2){
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    void StareAtPlayer()
    {
        transform.LookAt(playerTransform);
    }

    void LerpStareAtPlayer()
    {
        Vector3 direction = playerTransform.position - transform.position;
        float angle = Vector3.Angle(direction.normalized, transform.forward);
        Quaternion newRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime);
    }

    private void RotateAroundPlayer()
    {
        StareAtPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 5f * Time.deltaTime);
    }
     
}
