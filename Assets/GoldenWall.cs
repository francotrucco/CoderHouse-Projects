using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWall : MonoBehaviour
{
    private float timer;
    public float timerDuration = 2f;
    GameObject floor;

    void Start()
    {
        floor = GameObject.Find("Floor");

        if (floor == null)
        {
            Debug.LogError("Floor not found");
        }
    }
    void OnTriggerEnter()
    {
        RestartTimer();
    }

    void OnTriggerStay()
    {
        TickTimer();

        if (timer <= 0)
        {
            MoveWall();
        }
    }

    void RestartTimer()
    {
        timer = timerDuration;
    }

    void TickTimer()
    {
        timer -= Time.deltaTime;
    }

    void MoveWall()
    {
        Collider floorCollider = floor.GetComponent<Collider>();
        Vector3 maxBounds = floorCollider.bounds.max;
        Vector3 minBounds = floorCollider.bounds.min;

        minBounds.x += 5;
        minBounds.z += 2;

        Vector3 newPosition = new Vector3(Random.Range(minBounds.x, maxBounds.x), transform.transform.position.y, Random.Range(minBounds.z, maxBounds.z));

        int yRotation = Random.Range(-90, 90);
        Quaternion newRotation = Quaternion.Euler(transform.rotation.x, yRotation, transform.rotation.z);
        transform.SetPositionAndRotation(newPosition, newRotation);
    }
}
