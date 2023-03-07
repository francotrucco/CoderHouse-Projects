using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform gunPoint;
    public float range = 50f;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(gunPoint.position, gunPoint.forward, out hit, range)) 
        {
            if (hit.transform.CompareTag("Enemy"))
            {
                Vector3 positionToMove = Vector3.MoveTowards(transform.position, hit.transform.position, 0);
                transform.Translate(positionToMove * Time.deltaTime, hit.transform);
            }
        }
    }
}
