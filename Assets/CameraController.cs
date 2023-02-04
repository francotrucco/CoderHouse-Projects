using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject firstCamera;
    public GameObject secondCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            firstCamera.SetActive(!firstCamera.activeSelf);
            secondCamera.SetActive(!secondCamera.activeSelf);
        }
    }
}
