using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorHolder : MonoBehaviour
{
    // This destroys the gameObject that collides with this gameObject(Collector)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            Destroy(collision.gameObject);
        }
    }

}
