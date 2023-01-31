using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 direction = Vector3.forward;
    public int damage = 10;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
