using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 80f;

    // Update is called once per frame
    void Update()
    {
        float horMov = Input.GetAxis("Horizontal");
        float verMov = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horMov, 0, verMov) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));
        }
    }
}
