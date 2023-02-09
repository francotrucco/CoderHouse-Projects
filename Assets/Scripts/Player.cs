using UnityEngine;

public class Player : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    if(Input.GetKey(KeyCode.W))
    {
      transform.position += new Vector3(0,0,0.1f);
    }

    if(Input.GetKey(KeyCode.S))
    {
      transform.position += new Vector3(0,0,-0.1f);
    }

    if(Input.GetKey(KeyCode.A))
    {
      transform.position += new Vector3(-0.1f,0,0);
    }

     if(Input.GetKey(KeyCode.D))
    {
      transform.position += new Vector3(0.1f,0,0);
    }
    if(Input.GetKey(KeyCode.Q))
    {
      transform.Rotate(0,-1,0);
    }
    
    if(Input.GetKey(KeyCode.E))
    {
      transform.Rotate(0,1,0);
    }

  }  
    



}
