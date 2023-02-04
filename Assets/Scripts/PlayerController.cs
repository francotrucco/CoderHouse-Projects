using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        float horMov = Input.GetAxis("Horizontal");
        float verMov = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horMov, 0, verMov) * speed * Time.deltaTime);
    }
}
