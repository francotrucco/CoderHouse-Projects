using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;


    public IEnumerator FireBurst(int burstSize)
    {
        for (int i = 0; i < burstSize; i++)
        {
            Shoot();
            
            yield return new WaitForSeconds(0.2f);
        }
    }

    void Update()
    {
        if (Input.anyKeyDown && Time.time > nextFire)
        {
            if (Input.GetKey(KeyCode.Space)) 
            {
                StartCoroutine(FireBurst(1));
            }
            if (Input.GetKey(KeyCode.J)) 
            {
                StartCoroutine(FireBurst(2));
            }
            if (Input.GetKey(KeyCode.K)) 
            {
                StartCoroutine(FireBurst(3));
            }
            if (Input.GetKey(KeyCode.L)) 
            {
                StartCoroutine(FireBurst(4));
            }

            nextFire = Time.time + fireRate;
        }

    }

    void Shoot()
    {
        GameObject instance = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        Object.Destroy(instance, 5f);
    }
}
