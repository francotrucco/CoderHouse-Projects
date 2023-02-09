using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public int measureToResize = 2;
    bool wasPlayerResized = false;

    void OnTriggerEnter(Collider collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            if (wasPlayerResized)
            {
                player.transform.localScale *= measureToResize;
            } else {
                player.transform.localScale /= measureToResize;
            }
            
            wasPlayerResized = !wasPlayerResized;
        }
    }
}
