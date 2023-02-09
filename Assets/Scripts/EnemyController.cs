using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType 
{
    Chaser,
    Watcher
}

public class EnemyController : MonoBehaviour
{
    GameObject player;
    public float speed = 4f;
    public float maxDistance = 4f;
    public float speedToLook = 2f;
    public EnemyType enemyType;

    // Update is called once per frame
    void RotateTowards(Transform objective)
    {
        Quaternion newRotation = Quaternion.LookRotation(objective.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }

    void MoveTowards(Transform objective)
    {
        float realDistance = Vector3.Distance(transform.position, objective.position);
        if (realDistance > maxDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, objective.position, speed * Time.deltaTime);
        }
    }

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        switch (enemyType)
        {
            case EnemyType.Chaser:
                MoveTowards(player.transform);
                break;
            case EnemyType.Watcher:
                RotateTowards(player.transform);
                break;
        }
    }
}
