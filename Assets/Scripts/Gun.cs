using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    AudioSource shootAudioSource;

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
    
    void Start() 
    {
        shootAudioSource = GetComponent<AudioSource>();

        if (shootAudioSource == null)
        {
            Debug.Log("Shoot audio source not found"); 
        }
    }

    void Shoot()
    {
        GameObject instance = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        shootAudioSource.Play();
        Object.Destroy(instance, 5f);
    }
}
