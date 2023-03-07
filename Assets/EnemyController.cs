using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform gunPoint;
    public float range = 50f;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(gunPoint.position, gunPoint.forward, out hit, range)) 
        {
            if (hit.transform.CompareTag("Player"))
            {
                transform.Translate(Vector3.MoveTowards(transform.position, hit.transform.position, 2f) * Time.deltaTime);
            }
        }
    }
}
